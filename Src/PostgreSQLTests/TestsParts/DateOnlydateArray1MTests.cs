

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
    internal partial interface IDateOnlyArraydateArray
    {
    }
    
    internal partial class DateOnlyArraydateArray : IDateOnlyArraydateArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1mi(
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1mi(
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
            queryMapType: typeof(DateOnlydateArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                )
            ]
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

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModelInner(connection, 43032176, 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModelInner(connection, 1523255949, 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

}, null);
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

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelInnerAsync(connection, 1327150460, 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelInnerAsync(connection, 1639510460, 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturning()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDateOnlyArraydateArray)this).InsertModelInnerReturning(connection, 1573208195, 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

}, null);
                Assert.That(id, Is.EqualTo(1573208195));

                id =  ((IDateOnlyArraydateArray)this).InsertModelInnerReturning(connection, 2071123204, 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

}, null);
                Assert.That(id, Is.EqualTo(2071123204));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 1118584325, 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

}, null);
                Assert.That(id, Is.EqualTo(1118584325));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 1634171249, 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

}, null);
                Assert.That(id, Is.EqualTo(1634171249));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 1762828030, 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

});
                Assert.That(id, Is.EqualTo(1762828030));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 1570631687, 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

});
                Assert.That(id, Is.EqualTo(1570631687));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 896744450, 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

}, null);
                Assert.That(id, Is.EqualTo(896744450));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 813352627, 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

});
                Assert.That(id, Is.EqualTo(813352627));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 24233739, 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

});
                Assert.That(id, Is.EqualTo(24233739));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 1803124832, 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

});
                Assert.That(id, Is.EqualTo(1803124832));

                id = await ((IDateOnlyArraydateArray)this).InsertModelInnerReturningAsync(connection, 935878617, 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

}, null);
                Assert.That(id, Is.EqualTo(935878617));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1m(
	id,
    value,
    nullablevalue,
    dateonlydatearray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
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

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModel(connection, 271308261, 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyArraydateArray)this).InsertModel(connection, 294653352, 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

}, 43032176);
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

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelAsync(connection, 948608572, 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyArraydateArray)this).InsertModelAsync(connection, 1467489201, 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

}, null, 1523255949);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray1m(
	id,
    value,
    nullablevalue,
    dateonlydatearray1mi_id
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
    dateonlydatearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateOnlydateArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.DateOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray1M> models = null;
                DateOnlydateArray1M model = null;

                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, 224813546, 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, 1843253085, 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

}, 1327150460).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, 954133837, 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDateOnlyArraydateArray)this).InsertModelReturning(connection, 1664035342, 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

}, 1639510460).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray1M> models = null;
                DateOnlydateArray1M model = null;

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 1140313481, 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 1371436240, 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

}, 1573208195).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 226678507, 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 258653441, 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

}, 2071123204).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 239802889, 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 318138201, 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

}, null, 1118584325).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 341022441, 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 450420174, 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

}, 1634171249).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 1507940712, 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 530922630, 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

}, 1762828030).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 734248470, 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 347088587, 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

}, 1570631687).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 457435653, 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 227436991, 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

}, null, 896744450).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 580652360, 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 266272374, 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

}, 813352627).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 1492594161, 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 1641757108, 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

}, 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

}, 24233739).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 259689783, 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 29731329, 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

}, null, 1803124832).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 634171247, 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

}, 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDateOnlyArraydateArray)this).InsertModelReturningAsync(connection, 912530945, 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

}, null, 935878617).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        #endregion

#region Select Models

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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateOnlydateArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models =  ((IDateOnlyArraydateArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyArraydateArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
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
FROM public.dateonlydatearray1m m
LEFT JOIN public.dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateOnlydateArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
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
                var models =  ((IDateOnlyArraydateArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyArraydateArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlyArraydateArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlyArraydateArray)this).SetDbConnectionSelectModelParametrs(cmd, 318138201);
                var models =  ((IDateOnlyArraydateArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(19));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlyArraydateArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlyArraydateArray)this).SetDbConnectionSelectModelParametrs(cmd, 734248470);
                var models = await ((IDateOnlyArraydateArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(11));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyArraydateArray)
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
                 foreach(var batchResult in ((IDateOnlyArraydateArray)this).DbConnectionSelectModelBatch(connection, 530922630, 294653352))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

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
                await foreach(var batchResult in ((IDateOnlyArraydateArray)this).DbConnectionSelectModelBatchAsync(connection, 29731329, 948608572))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(29));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[28];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        continue;
                    }
                    
                    //todo return false
                }
            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_dateonlydatearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateOnlydateArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateOnlydateArray1MI>(7);

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 24233739,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

}
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 43032176,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 813352627,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

}
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 896744450,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 935878617,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1118584325,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1327150460,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24233739));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(43032176));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813352627));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896744450));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935878617));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1118584325));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1327150460));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1523255949,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1570631687,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

}
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1573208195,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1634171249,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1639510460,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1762828030,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

}
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 1803124832,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

}
                });

                importCollection.Add(
                new DateOnlydateArray1MI
                {
                    Id = 2071123204,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(24233739));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(43032176));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813352627));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(896744450));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(935878617));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1118584325));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1327150460));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1523255949));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570631687));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1573208195));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1634171249));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1639510460));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1762828030));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1803124832));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2071123204));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydatearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateOnlydateArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
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
FROM public.binary_dateonlydatearray1m m
LEFT JOIN public.binary_dateonlydatearray1mi mi ON mi.id = m.dateonlydatearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateOnlydateArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public
            )
            ]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DateOnlydateArray1M>(15);

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 29731329,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1803124832
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 224813546,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 226678507,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 227436991,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 896744450
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 239802889,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 258653441,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 2071123204
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 259689783,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 266272374,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 813352627
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 271308261,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 294653352,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 43032176
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 318138201,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1118584325
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 341022441,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 347088587,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1570631687
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 450420174,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1634171249
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 457435653,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 530922630,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1762828030
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 580652360,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 634171247,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 734248470,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 912530945,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 935878617
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 948608572,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 954133837,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1140313481,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1371436240,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1573208195
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1467489201,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1523255949
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1492594161,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1507940712,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1641757108,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 24233739
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1664035342,
                    Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

},
                    NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1639510460
                    }

                });

                importCollection.Add(
                new DateOnlydateArray1M
                {
                    Id = 1843253085,
                    Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

},
                    NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

},

                    ModelInner = new DateOnlydateArray1MI 
                    {
                        Id = 1327150460
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(29731329));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1803124832));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224813546));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(226678507));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227436991));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(896744450));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239802889));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258653441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2071123204));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259689783));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(266272374));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(813352627));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(271308261));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(294653352));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(43032176));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(318138201));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1118584325));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(341022441));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347088587));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570631687));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450420174));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634171249));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(457435653));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(530922630));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762828030));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(580652360));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(634171247));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(734248470));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(912530945));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(935878617));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(948608572));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(954133837));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1140313481));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1371436240));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1573208195));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1467489201));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523255949));

                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1492594161));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1507940712));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1641757108));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(24233739));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1664035342));
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1639510460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843253085));
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1327150460));

                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydatearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateOnlydateArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,DateOnlydateArray1M>(30);

                expected.Add(
                    29731329,
                    new DateOnlydateArray1M
                    {
                        Id = 29731329,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1803124832,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

}
                        }

                    }
                );

                expected.Add(
                    224813546,
                    new DateOnlydateArray1M
                    {
                        Id = 224813546,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    226678507,
                    new DateOnlydateArray1M
                    {
                        Id = 226678507,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    227436991,
                    new DateOnlydateArray1M
                    {
                        Id = 227436991,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 896744450,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    239802889,
                    new DateOnlydateArray1M
                    {
                        Id = 239802889,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    258653441,
                    new DateOnlydateArray1M
                    {
                        Id = 258653441,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 2071123204,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    259689783,
                    new DateOnlydateArray1M
                    {
                        Id = 259689783,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    266272374,
                    new DateOnlydateArray1M
                    {
                        Id = 266272374,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 813352627,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

}
                        }

                    }
                );

                expected.Add(
                    271308261,
                    new DateOnlydateArray1M
                    {
                        Id = 271308261,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    294653352,
                    new DateOnlydateArray1M
                    {
                        Id = 294653352,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 43032176,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    318138201,
                    new DateOnlydateArray1M
                    {
                        Id = 318138201,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1118584325,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    341022441,
                    new DateOnlydateArray1M
                    {
                        Id = 341022441,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    347088587,
                    new DateOnlydateArray1M
                    {
                        Id = 347088587,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1570631687,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

}
                        }

                    }
                );

                expected.Add(
                    450420174,
                    new DateOnlydateArray1M
                    {
                        Id = 450420174,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1634171249,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    457435653,
                    new DateOnlydateArray1M
                    {
                        Id = 457435653,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    530922630,
                    new DateOnlydateArray1M
                    {
                        Id = 530922630,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1762828030,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

}
                        }

                    }
                );

                expected.Add(
                    580652360,
                    new DateOnlydateArray1M
                    {
                        Id = 580652360,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    634171247,
                    new DateOnlydateArray1M
                    {
                        Id = 634171247,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    734248470,
                    new DateOnlydateArray1M
                    {
                        Id = 734248470,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    912530945,
                    new DateOnlydateArray1M
                    {
                        Id = 912530945,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 935878617,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948608572,
                    new DateOnlydateArray1M
                    {
                        Id = 948608572,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    954133837,
                    new DateOnlydateArray1M
                    {
                        Id = 954133837,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1140313481,
                    new DateOnlydateArray1M
                    {
                        Id = 1140313481,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1371436240,
                    new DateOnlydateArray1M
                    {
                        Id = 1371436240,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1573208195,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1467489201,
                    new DateOnlydateArray1M
                    {
                        Id = 1467489201,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1523255949,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1492594161,
                    new DateOnlydateArray1M
                    {
                        Id = 1492594161,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1507940712,
                    new DateOnlydateArray1M
                    {
                        Id = 1507940712,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1641757108,
                    new DateOnlydateArray1M
                    {
                        Id = 1641757108,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 24233739,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

}
                        }

                    }
                );

                expected.Add(
                    1664035342,
                    new DateOnlydateArray1M
                    {
                        Id = 1664035342,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1639510460,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1843253085,
                    new DateOnlydateArray1M
                    {
                        Id = 1843253085,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1327150460,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

}
                        }

                    }
                );

                var models =  ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,DateOnlydateArray1M>(30);

                expected.Add(
                    29731329,
                    new DateOnlydateArray1M
                    {
                        Id = 29731329,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1991, month: 10, day: 13),

new DateOnly(year: 1957, month: 10, day: 12),

new DateOnly(year: 1929, month: 10, day: 12),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1803124832,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

}
                        }

                    }
                );

                expected.Add(
                    224813546,
                    new DateOnlydateArray1M
                    {
                        Id = 224813546,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1998, month: 10, day: 14),

new DateOnly(year: 1957, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    226678507,
                    new DateOnlydateArray1M
                    {
                        Id = 226678507,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2011, month: 10, day: 18),

new DateOnly(year: 1970, month: 10, day: 11),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    227436991,
                    new DateOnlydateArray1M
                    {
                        Id = 227436991,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2014, month: 10, day: 15),

new DateOnly(year: 1996, month: 10, day: 9),

new DateOnly(year: 1940, month: 10, day: 10),

new DateOnly(year: 1976, month: 10, day: 13),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 896744450,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    239802889,
                    new DateOnlydateArray1M
                    {
                        Id = 239802889,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 5),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1956, month: 10, day: 7),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    258653441,
                    new DateOnlydateArray1M
                    {
                        Id = 258653441,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1919, month: 10, day: 15),

new DateOnly(year: 1954, month: 10, day: 8),

new DateOnly(year: 2017, month: 10, day: 8),

new DateOnly(year: 1922, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1931, month: 10, day: 2),

new DateOnly(year: 1939, month: 10, day: 15),

new DateOnly(year: 2013, month: 10, day: 12),

new DateOnly(year: 1996, month: 10, day: 15),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 2071123204,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    259689783,
                    new DateOnlydateArray1M
                    {
                        Id = 259689783,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1922, month: 10, day: 9),

new DateOnly(year: 2011, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 8),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    266272374,
                    new DateOnlydateArray1M
                    {
                        Id = 266272374,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1994, month: 10, day: 18),

new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1991, month: 10, day: 16),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1979, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 15),

new DateOnly(year: 1969, month: 10, day: 10),

new DateOnly(year: 1983, month: 10, day: 10),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 813352627,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

}
                        }

                    }
                );

                expected.Add(
                    271308261,
                    new DateOnlydateArray1M
                    {
                        Id = 271308261,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1989, month: 10, day: 3),

new DateOnly(year: 1976, month: 10, day: 13),

new DateOnly(year: 2011, month: 10, day: 4),

new DateOnly(year: 2013, month: 10, day: 14),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1918, month: 10, day: 8),

new DateOnly(year: 1928, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 1),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    294653352,
                    new DateOnlydateArray1M
                    {
                        Id = 294653352,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1959, month: 10, day: 3),

new DateOnly(year: 1955, month: 10, day: 2),

new DateOnly(year: 2011, month: 10, day: 8),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1944, month: 10, day: 3),

new DateOnly(year: 1927, month: 10, day: 5),

new DateOnly(year: 1981, month: 10, day: 7),

new DateOnly(year: 1967, month: 10, day: 18),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 43032176,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    318138201,
                    new DateOnlydateArray1M
                    {
                        Id = 318138201,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2019, month: 10, day: 14),

new DateOnly(year: 2016, month: 10, day: 12),

new DateOnly(year: 1935, month: 10, day: 18),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1118584325,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    341022441,
                    new DateOnlydateArray1M
                    {
                        Id = 341022441,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1938, month: 10, day: 1),

new DateOnly(year: 1955, month: 10, day: 3),

new DateOnly(year: 1947, month: 10, day: 16),

new DateOnly(year: 1985, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 18),

new DateOnly(year: 1982, month: 10, day: 7),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 15),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    347088587,
                    new DateOnlydateArray1M
                    {
                        Id = 347088587,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1924, month: 10, day: 15),

new DateOnly(year: 1967, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 10),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1939, month: 10, day: 4),

new DateOnly(year: 1937, month: 10, day: 11),

new DateOnly(year: 1992, month: 10, day: 11),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1570631687,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

}
                        }

                    }
                );

                expected.Add(
                    450420174,
                    new DateOnlydateArray1M
                    {
                        Id = 450420174,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1989, month: 10, day: 17),

new DateOnly(year: 2004, month: 10, day: 7),

new DateOnly(year: 1965, month: 10, day: 16),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1993, month: 10, day: 18),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 6),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1634171249,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    457435653,
                    new DateOnlydateArray1M
                    {
                        Id = 457435653,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1920, month: 10, day: 16),

new DateOnly(year: 2019, month: 10, day: 8),

new DateOnly(year: 2011, month: 10, day: 8),

new DateOnly(year: 2013, month: 10, day: 12),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

new DateOnly(year: 1929, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    530922630,
                    new DateOnlydateArray1M
                    {
                        Id = 530922630,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1975, month: 10, day: 2),

new DateOnly(year: 1993, month: 10, day: 15),

new DateOnly(year: 1976, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1970, month: 10, day: 14),

new DateOnly(year: 1963, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 6),

new DateOnly(year: 1998, month: 10, day: 2),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1762828030,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

}
                        }

                    }
                );

                expected.Add(
                    580652360,
                    new DateOnlydateArray1M
                    {
                        Id = 580652360,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1992, month: 10, day: 2),

new DateOnly(year: 1947, month: 10, day: 10),

new DateOnly(year: 1935, month: 10, day: 5),

new DateOnly(year: 1930, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1981, month: 10, day: 9),

new DateOnly(year: 2006, month: 10, day: 12),

new DateOnly(year: 1981, month: 10, day: 17),

new DateOnly(year: 1966, month: 10, day: 8),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    634171247,
                    new DateOnlydateArray1M
                    {
                        Id = 634171247,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2016, month: 10, day: 5),

new DateOnly(year: 2019, month: 10, day: 17),

new DateOnly(year: 1935, month: 10, day: 14),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1932, month: 10, day: 11),

new DateOnly(year: 1922, month: 10, day: 16),

new DateOnly(year: 1969, month: 10, day: 16),

new DateOnly(year: 1922, month: 10, day: 18),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    734248470,
                    new DateOnlydateArray1M
                    {
                        Id = 734248470,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1958, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 1),

new DateOnly(year: 2007, month: 10, day: 17),

new DateOnly(year: 1957, month: 10, day: 10),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    912530945,
                    new DateOnlydateArray1M
                    {
                        Id = 912530945,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1923, month: 10, day: 14),

new DateOnly(year: 1970, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 14),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 935878617,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    948608572,
                    new DateOnlydateArray1M
                    {
                        Id = 948608572,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1991, month: 10, day: 1),

new DateOnly(year: 2017, month: 10, day: 16),

new DateOnly(year: 1984, month: 10, day: 12),

new DateOnly(year: 1946, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2001, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 14),

new DateOnly(year: 2009, month: 10, day: 12),

new DateOnly(year: 1984, month: 10, day: 12),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    954133837,
                    new DateOnlydateArray1M
                    {
                        Id = 954133837,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1934, month: 10, day: 16),

new DateOnly(year: 1976, month: 10, day: 1),

new DateOnly(year: 1953, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1997, month: 10, day: 17),

new DateOnly(year: 1925, month: 10, day: 5),

new DateOnly(year: 1962, month: 10, day: 15),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1140313481,
                    new DateOnlydateArray1M
                    {
                        Id = 1140313481,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1955, month: 10, day: 9),

new DateOnly(year: 1926, month: 10, day: 19),

new DateOnly(year: 1947, month: 10, day: 18),

new DateOnly(year: 2014, month: 10, day: 5),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 5),

new DateOnly(year: 1987, month: 10, day: 15),

new DateOnly(year: 1972, month: 10, day: 13),

new DateOnly(year: 2018, month: 10, day: 1),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1371436240,
                    new DateOnlydateArray1M
                    {
                        Id = 1371436240,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1986, month: 10, day: 7),

new DateOnly(year: 1991, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 8),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1949, month: 10, day: 6),

new DateOnly(year: 2001, month: 10, day: 5),

new DateOnly(year: 1977, month: 10, day: 18),

new DateOnly(year: 1936, month: 10, day: 5),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1573208195,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1467489201,
                    new DateOnlydateArray1M
                    {
                        Id = 1467489201,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2013, month: 10, day: 16),

new DateOnly(year: 1945, month: 10, day: 5),

new DateOnly(year: 1961, month: 10, day: 12),

new DateOnly(year: 1975, month: 10, day: 18),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1523255949,
                            Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1492594161,
                    new DateOnlydateArray1M
                    {
                        Id = 1492594161,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1980, month: 10, day: 19),

new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1994, month: 10, day: 1),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1507940712,
                    new DateOnlydateArray1M
                    {
                        Id = 1507940712,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1996, month: 10, day: 19),

new DateOnly(year: 1917, month: 10, day: 3),

new DateOnly(year: 1933, month: 10, day: 17),

new DateOnly(year: 1968, month: 10, day: 10),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1973, month: 10, day: 4),

new DateOnly(year: 1934, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1641757108,
                    new DateOnlydateArray1M
                    {
                        Id = 1641757108,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2000, month: 10, day: 16),

new DateOnly(year: 1965, month: 10, day: 16),

new DateOnly(year: 1917, month: 10, day: 4),

new DateOnly(year: 1932, month: 10, day: 17),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1982, month: 10, day: 3),

new DateOnly(year: 1974, month: 10, day: 16),

new DateOnly(year: 1943, month: 10, day: 12),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 24233739,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

},
                            NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

}
                        }

                    }
                );

                expected.Add(
                    1664035342,
                    new DateOnlydateArray1M
                    {
                        Id = 1664035342,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1963, month: 10, day: 17),

new DateOnly(year: 1947, month: 10, day: 6),

new DateOnly(year: 2013, month: 10, day: 4),

new DateOnly(year: 2000, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2007, month: 10, day: 8),

new DateOnly(year: 1962, month: 10, day: 10),

new DateOnly(year: 1993, month: 10, day: 13),

new DateOnly(year: 1960, month: 10, day: 16),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1639510460,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1843253085,
                    new DateOnlydateArray1M
                    {
                        Id = 1843253085,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1950, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 2),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 2006, month: 10, day: 18),

new DateOnly(year: 1998, month: 10, day: 5),

new DateOnly(year: 1918, month: 10, day: 12),

},

                        ModelInner = new DateOnlydateArray1MI
                        {
                            Id = 1327150460,
                            Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

},
                            NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

}
                        }

                    }
                );

                var models = await ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                    }
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.DateOnly[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateOnlydateArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641),
                (NpgsqlTypes.NpgsqlDbType)(-2147483641)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public
            )
            ]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,DateOnlydateArray1MI>(15);

                expected.Add(
                    24233739,
                    new DateOnlydateArray1MI
                    {
                        Id = 24233739,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

}
                    }
                );

                expected.Add(
                    43032176,
                    new DateOnlydateArray1MI
                    {
                        Id = 43032176,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    813352627,
                    new DateOnlydateArray1MI
                    {
                        Id = 813352627,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

}
                    }
                );

                expected.Add(
                    896744450,
                    new DateOnlydateArray1MI
                    {
                        Id = 896744450,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    935878617,
                    new DateOnlydateArray1MI
                    {
                        Id = 935878617,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1118584325,
                    new DateOnlydateArray1MI
                    {
                        Id = 1118584325,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1327150460,
                    new DateOnlydateArray1MI
                    {
                        Id = 1327150460,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

}
                    }
                );

                expected.Add(
                    1523255949,
                    new DateOnlydateArray1MI
                    {
                        Id = 1523255949,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1570631687,
                    new DateOnlydateArray1MI
                    {
                        Id = 1570631687,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

}
                    }
                );

                expected.Add(
                    1573208195,
                    new DateOnlydateArray1MI
                    {
                        Id = 1573208195,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1634171249,
                    new DateOnlydateArray1MI
                    {
                        Id = 1634171249,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1639510460,
                    new DateOnlydateArray1MI
                    {
                        Id = 1639510460,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762828030,
                    new DateOnlydateArray1MI
                    {
                        Id = 1762828030,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

}
                    }
                );

                expected.Add(
                    1803124832,
                    new DateOnlydateArray1MI
                    {
                        Id = 1803124832,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

}
                    }
                );

                expected.Add(
                    2071123204,
                    new DateOnlydateArray1MI
                    {
                        Id = 2071123204,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

},
                        NullableValue = null
                    }
                );

                var models =  ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var expected = new Dictionary<System.Int32,DateOnlydateArray1MI>(15);

                expected.Add(
                    24233739,
                    new DateOnlydateArray1MI
                    {
                        Id = 24233739,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 2010, month: 10, day: 17),

new DateOnly(year: 1982, month: 10, day: 5),

new DateOnly(year: 1925, month: 10, day: 12),

new DateOnly(year: 1979, month: 10, day: 2),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1962, month: 10, day: 6),

new DateOnly(year: 1945, month: 10, day: 18),

new DateOnly(year: 1978, month: 10, day: 5),

}
                    }
                );

                expected.Add(
                    43032176,
                    new DateOnlydateArray1MI
                    {
                        Id = 43032176,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1924, month: 10, day: 17),

new DateOnly(year: 1989, month: 10, day: 7),

new DateOnly(year: 1995, month: 10, day: 6),

new DateOnly(year: 1963, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    813352627,
                    new DateOnlydateArray1MI
                    {
                        Id = 813352627,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1927, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 9),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1980, month: 10, day: 15),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1945, month: 10, day: 14),

new DateOnly(year: 2007, month: 10, day: 14),

new DateOnly(year: 1953, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 19),

}
                    }
                );

                expected.Add(
                    896744450,
                    new DateOnlydateArray1MI
                    {
                        Id = 896744450,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2003, month: 10, day: 10),

new DateOnly(year: 1939, month: 10, day: 9),

new DateOnly(year: 1960, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    935878617,
                    new DateOnlydateArray1MI
                    {
                        Id = 935878617,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1977, month: 10, day: 14),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 2012, month: 10, day: 5),

new DateOnly(year: 1948, month: 10, day: 13),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1118584325,
                    new DateOnlydateArray1MI
                    {
                        Id = 1118584325,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1929, month: 10, day: 18),

new DateOnly(year: 1958, month: 10, day: 13),

new DateOnly(year: 1931, month: 10, day: 10),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1327150460,
                    new DateOnlydateArray1MI
                    {
                        Id = 1327150460,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1961, month: 10, day: 1),

new DateOnly(year: 1984, month: 10, day: 7),

new DateOnly(year: 2002, month: 10, day: 13),

new DateOnly(year: 1952, month: 10, day: 5),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 2016, month: 10, day: 1),

new DateOnly(year: 1983, month: 10, day: 6),

new DateOnly(year: 1929, month: 10, day: 12),

new DateOnly(year: 1993, month: 10, day: 10),

}
                    }
                );

                expected.Add(
                    1523255949,
                    new DateOnlydateArray1MI
                    {
                        Id = 1523255949,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 2004, month: 10, day: 13),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1964, month: 10, day: 14),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1570631687,
                    new DateOnlydateArray1MI
                    {
                        Id = 1570631687,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1967, month: 10, day: 12),

new DateOnly(year: 1980, month: 10, day: 8),

new DateOnly(year: 1923, month: 10, day: 9),

},
                        NullableValue = 
new System.DateOnly[4]
{
new DateOnly(year: 1956, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 3),

new DateOnly(year: 1925, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 5),

}
                    }
                );

                expected.Add(
                    1573208195,
                    new DateOnlydateArray1MI
                    {
                        Id = 1573208195,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1942, month: 10, day: 13),

new DateOnly(year: 1972, month: 10, day: 8),

new DateOnly(year: 1919, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1634171249,
                    new DateOnlydateArray1MI
                    {
                        Id = 1634171249,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1972, month: 10, day: 16),

new DateOnly(year: 1949, month: 10, day: 9),

new DateOnly(year: 1973, month: 10, day: 16),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1639510460,
                    new DateOnlydateArray1MI
                    {
                        Id = 1639510460,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1975, month: 10, day: 13),

new DateOnly(year: 2009, month: 10, day: 16),

new DateOnly(year: 1942, month: 10, day: 17),

new DateOnly(year: 2000, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762828030,
                    new DateOnlydateArray1MI
                    {
                        Id = 1762828030,
                        Value = 
new System.DateOnly[3]
{
new DateOnly(year: 1998, month: 10, day: 12),

new DateOnly(year: 2007, month: 10, day: 12),

new DateOnly(year: 1963, month: 10, day: 1),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1957, month: 10, day: 8),

new DateOnly(year: 1925, month: 10, day: 11),

new DateOnly(year: 1954, month: 10, day: 7),

}
                    }
                );

                expected.Add(
                    1803124832,
                    new DateOnlydateArray1MI
                    {
                        Id = 1803124832,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1925, month: 10, day: 16),

new DateOnly(year: 1999, month: 10, day: 12),

new DateOnly(year: 1994, month: 10, day: 7),

},
                        NullableValue = 
new System.DateOnly[3]
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1984, month: 10, day: 5),

new DateOnly(year: 1975, month: 10, day: 4),

}
                    }
                );

                expected.Add(
                    2071123204,
                    new DateOnlydateArray1MI
                    {
                        Id = 2071123204,
                        Value = 
new System.DateOnly[4]
{
new DateOnly(year: 1954, month: 10, day: 16),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1973, month: 10, day: 19),

new DateOnly(year: 1921, month: 10, day: 13),

},
                        NullableValue = null
                    }
                );

                var models = await ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = expected[model.Id];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(expectedModel.Id));
                {
                    var expectEnumerValue = expectedModel.Value;
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    {
                        var expectEnumerValue = expectedModel.NullableValue;
                        Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                        for(int i = 0; i < expectEnumerValue.Count(); i++)
                        {
                            var expectItem = expectEnumerValue[i];
                            var haveItem = model.NullableValue[i];
                            Assert.That(expectItem, Is.EqualTo(haveItem));
                        }
                }
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Null);
                }


                }
            }
        }

        #endregion

    }
}

