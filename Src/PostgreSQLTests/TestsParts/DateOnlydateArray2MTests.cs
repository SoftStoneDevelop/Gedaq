

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
    internal partial interface IDateOnlyListdateArray
    {
    }
    
    internal partial class DateOnlyListdateArray : IDateOnlyListdateArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2mi(
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
            asPartInterface: typeof(IDateOnlyListdateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
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
INSERT INTO public.dateonlydatearray2mi(
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
            queryMapType: typeof(DateOnlydateArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
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

                changedRows =  ((IDateOnlyListdateArray)this).InsertModelInner(connection, 474333893, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyListdateArray)this).InsertModelInner(connection, 151782977, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

});
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

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelInnerAsync(connection, 928186054, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelInnerAsync(connection, 1195001246, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                id =  ((IDateOnlyListdateArray)this).InsertModelInnerReturning(connection, 1876292561, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

});
                Assert.That(id, Is.EqualTo(1876292561));

                id =  ((IDateOnlyListdateArray)this).InsertModelInnerReturning(connection, 1297542691, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

}, null);
                Assert.That(id, Is.EqualTo(1297542691));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 1157805165, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

});
                Assert.That(id, Is.EqualTo(1157805165));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 1716836921, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

}, null);
                Assert.That(id, Is.EqualTo(1716836921));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 1302266743, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

});
                Assert.That(id, Is.EqualTo(1302266743));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 207362866, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

}, null);
                Assert.That(id, Is.EqualTo(207362866));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 449048751, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

}, null);
                Assert.That(id, Is.EqualTo(449048751));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 521115608, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

});
                Assert.That(id, Is.EqualTo(521115608));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 378598370, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

}, null);
                Assert.That(id, Is.EqualTo(378598370));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 1069208345, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

}, null);
                Assert.That(id, Is.EqualTo(1069208345));

                id = await ((IDateOnlyListdateArray)this).InsertModelInnerReturningAsync(connection, 1358741182, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

}, null);
                Assert.That(id, Is.EqualTo(1358741182));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2m(
	id,
    value,
    nullablevalue,
    dateonlydatearray2mi_id
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
            asPartInterface: typeof(IDateOnlyListdateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray2mi_id", 
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

                changedRows =  ((IDateOnlyListdateArray)this).InsertModel(connection, 1346540019, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDateOnlyListdateArray)this).InsertModel(connection, 250760014, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

}, null, 474333893);
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

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelAsync(connection, 1972502120, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDateOnlyListdateArray)this).InsertModelAsync(connection, 416931732, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

}, null, 151782977);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.dateonlydatearray2m(
	id,
    value,
    nullablevalue,
    dateonlydatearray2mi_id
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
    dateonlydatearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DateOnlydateArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.DateOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483641)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "dateonlydatearray2mi_id", 
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
                List<DateOnlydateArray2M> models = null;
                DateOnlydateArray2M model = null;

                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, 713510294, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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

                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, 1779889922, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

}, 928186054).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, 419027208, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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

                models =  ((IDateOnlyListdateArray)this).InsertModelReturning(connection, 1165487876, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

}, null, 1195001246).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DateOnlydateArray2M> models = null;
                DateOnlydateArray2M model = null;

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 135498313, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 784231727, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

}, 1876292561).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 239523493, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 565662533, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

}, 1297542691).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 313784574, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 61315805, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

}, 1157805165).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 982572110, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 563997982, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

new DateOnly(year: 1985, month: 10, day: 17),

}, null, 1716836921).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 893427232, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1309365022, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

}, 1302266743).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 747175902, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1347243701, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

}, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

}, 207362866).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1083619520, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 664191186, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

}, null, 449048751).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1806882227, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 610996681, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

}, null, 521115608).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 431511944, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 520711680, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

}, null, 378598370).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 542073896, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1317580269, 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

}, null, 1069208345).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 1904334101, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                models = await ((IDateOnlyListdateArray)this).InsertModelReturningAsync(connection, 2119137426, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

}, 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

}, 1358741182).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
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
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DateOnlydateArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)
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
                var models =  ((IDateOnlyListdateArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyListdateArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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
FROM public.dateonlydatearray2m m
LEFT JOIN public.dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DateOnlydateArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)
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
                var models =  ((IDateOnlyListdateArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDateOnlyListdateArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDateOnlyListdateArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDateOnlyListdateArray)this).SetDbConnectionSelectModelParametrs(cmd, 664191186);
                var models =  ((IDateOnlyListdateArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

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
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDateOnlyListdateArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDateOnlyListdateArray)this).SetDbConnectionSelectModelParametrs(cmd, 250760014);
                var models = await ((IDateOnlyListdateArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

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
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDateOnlyListdateArray)
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
                 foreach(var batchResult in ((IDateOnlyListdateArray)this).DbConnectionSelectModelBatch(connection, 1317580269, 61315805))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(29));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                        model = models[28];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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
                await foreach(var batchResult in ((IDateOnlyListdateArray)this).DbConnectionSelectModelBatchAsync(connection, 1346540019, 250760014))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

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
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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
COPY public.binary_dateonlydatearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DateOnlydateArray2MI),
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
FROM public.binary_dateonlydatearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DateOnlydateArray2MI),
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

                var importCollection = new List<DateOnlydateArray2MI>(7);

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 151782977,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

}
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 207362866,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 378598370,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 449048751,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 474333893,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

}
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 521115608,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

}
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 928186054,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151782977));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(207362866));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(378598370));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449048751));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(474333893));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(521115608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928186054));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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

                importCollection.Clear();

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1069208345,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1157805165,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

}
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1195001246,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1297542691,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1302266743,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

}
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1358741182,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1716836921,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

},
                    NullableValue = null
                });

                importCollection.Add(
                new DateOnlydateArray2MI
                {
                    Id = 1876292561,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(151782977));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(207362866));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(378598370));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(449048751));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(474333893));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(521115608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(928186054));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069208345));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1157805165));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(1195001246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(1297542691));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1302266743));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1358741182));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1716836921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1876292561));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_dateonlydatearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
dateonlydatearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DateOnlydateArray2M),
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
FROM public.binary_dateonlydatearray2m m
LEFT JOIN public.binary_dateonlydatearray2mi mi ON mi.id = m.dateonlydatearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DateOnlydateArray2M),
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

                var importCollection = new List<DateOnlydateArray2M>(15);

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 61315805,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1157805165
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 135498313,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 239523493,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 250760014,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 474333893
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 313784574,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 416931732,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 151782977
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 419027208,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 431511944,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 520711680,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 378598370
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 542073896,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 563997982,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

new DateOnly(year: 1985, month: 10, day: 17),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1716836921
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 565662533,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1297542691
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 610996681,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 521115608
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 664191186,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 449048751
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 713510294,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                new DateOnlydateArray2M
                {
                    Id = 747175902,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 784231727,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1876292561
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 893427232,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 982572110,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1083619520,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1165487876,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1195001246
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1309365022,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1302266743
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1317580269,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

},
                    NullableValue = null,

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1069208345
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1346540019,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1347243701,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 207362866
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1779889922,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 928186054
                    }

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1806882227,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1904334101,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 1972502120,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

},

                    ModelInner = null

                });

                importCollection.Add(
                new DateOnlydateArray2M
                {
                    Id = 2119137426,
                    Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

},
                    NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

},

                    ModelInner = new DateOnlydateArray2MI 
                    {
                        Id = 1358741182
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(61315805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1157805165));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(135498313));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

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
                Assert.That(model.Id, Is.EqualTo(239523493));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

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
                Assert.That(model.Id, Is.EqualTo(250760014));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(474333893));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(313784574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(416931732));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(151782977));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(419027208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

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
                Assert.That(model.Id, Is.EqualTo(431511944));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(520711680));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(378598370));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(542073896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

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
                Assert.That(model.Id, Is.EqualTo(563997982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

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

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716836921));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

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
                Assert.That(model.Id, Is.EqualTo(565662533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1297542691));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

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


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(610996681));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(521115608));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

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
                Assert.That(model.Id, Is.EqualTo(664191186));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(449048751));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

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
                Assert.That(model.Id, Is.EqualTo(713510294));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

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
                Assert.That(model.Id, Is.EqualTo(747175902));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

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
                Assert.That(model.Id, Is.EqualTo(784231727));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1876292561));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.Id, Is.EqualTo(893427232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

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
                Assert.That(model.Id, Is.EqualTo(982572110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

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
                Assert.That(model.Id, Is.EqualTo(1083619520));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

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
                Assert.That(model.Id, Is.EqualTo(1165487876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1195001246));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

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


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309365022));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1302266743));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1317580269));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1069208345));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

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
                Assert.That(model.Id, Is.EqualTo(1346540019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

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


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1347243701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(207362866));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

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
                Assert.That(model.Id, Is.EqualTo(1779889922));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(928186054));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

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


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806882227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

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


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1904334101));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972502120));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

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
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2119137426));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

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
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1358741182));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    dateonlydatearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DateOnlydateArray2M),
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

                var expected = new Dictionary<System.Int32,DateOnlydateArray2M>(30);

                expected.Add(
                    61315805,
                    new DateOnlydateArray2M
                    {
                        Id = 61315805,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1157805165,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

}
                        }

                    }
                );

                expected.Add(
                    135498313,
                    new DateOnlydateArray2M
                    {
                        Id = 135498313,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    239523493,
                    new DateOnlydateArray2M
                    {
                        Id = 239523493,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    250760014,
                    new DateOnlydateArray2M
                    {
                        Id = 250760014,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 474333893,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

}
                        }

                    }
                );

                expected.Add(
                    313784574,
                    new DateOnlydateArray2M
                    {
                        Id = 313784574,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    416931732,
                    new DateOnlydateArray2M
                    {
                        Id = 416931732,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 151782977,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

}
                        }

                    }
                );

                expected.Add(
                    419027208,
                    new DateOnlydateArray2M
                    {
                        Id = 419027208,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    431511944,
                    new DateOnlydateArray2M
                    {
                        Id = 431511944,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    520711680,
                    new DateOnlydateArray2M
                    {
                        Id = 520711680,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 378598370,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    542073896,
                    new DateOnlydateArray2M
                    {
                        Id = 542073896,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    563997982,
                    new DateOnlydateArray2M
                    {
                        Id = 563997982,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

new DateOnly(year: 1985, month: 10, day: 17),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1716836921,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    565662533,
                    new DateOnlydateArray2M
                    {
                        Id = 565662533,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1297542691,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    610996681,
                    new DateOnlydateArray2M
                    {
                        Id = 610996681,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 521115608,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

}
                        }

                    }
                );

                expected.Add(
                    664191186,
                    new DateOnlydateArray2M
                    {
                        Id = 664191186,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 449048751,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    713510294,
                    new DateOnlydateArray2M
                    {
                        Id = 713510294,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    747175902,
                    new DateOnlydateArray2M
                    {
                        Id = 747175902,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    784231727,
                    new DateOnlydateArray2M
                    {
                        Id = 784231727,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1876292561,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

}
                        }

                    }
                );

                expected.Add(
                    893427232,
                    new DateOnlydateArray2M
                    {
                        Id = 893427232,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    982572110,
                    new DateOnlydateArray2M
                    {
                        Id = 982572110,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1083619520,
                    new DateOnlydateArray2M
                    {
                        Id = 1083619520,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1165487876,
                    new DateOnlydateArray2M
                    {
                        Id = 1165487876,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1195001246,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1309365022,
                    new DateOnlydateArray2M
                    {
                        Id = 1309365022,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1302266743,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

}
                        }

                    }
                );

                expected.Add(
                    1317580269,
                    new DateOnlydateArray2M
                    {
                        Id = 1317580269,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1069208345,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1346540019,
                    new DateOnlydateArray2M
                    {
                        Id = 1346540019,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1347243701,
                    new DateOnlydateArray2M
                    {
                        Id = 1347243701,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 207362866,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1779889922,
                    new DateOnlydateArray2M
                    {
                        Id = 1779889922,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 928186054,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1806882227,
                    new DateOnlydateArray2M
                    {
                        Id = 1806882227,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1904334101,
                    new DateOnlydateArray2M
                    {
                        Id = 1904334101,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972502120,
                    new DateOnlydateArray2M
                    {
                        Id = 1972502120,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2119137426,
                    new DateOnlydateArray2M
                    {
                        Id = 2119137426,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1358741182,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
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

                var expected = new Dictionary<System.Int32,DateOnlydateArray2M>(30);

                expected.Add(
                    61315805,
                    new DateOnlydateArray2M
                    {
                        Id = 61315805,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1999, month: 10, day: 5),

new DateOnly(year: 1917, month: 10, day: 10),

new DateOnly(year: 1971, month: 10, day: 17),

new DateOnly(year: 2012, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1932, month: 10, day: 18),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1157805165,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

}
                        }

                    }
                );

                expected.Add(
                    135498313,
                    new DateOnlydateArray2M
                    {
                        Id = 135498313,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1964, month: 10, day: 17),

new DateOnly(year: 1937, month: 10, day: 4),

new DateOnly(year: 2009, month: 10, day: 13),

new DateOnly(year: 1995, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1939, month: 10, day: 13),

new DateOnly(year: 2016, month: 10, day: 16),

new DateOnly(year: 1931, month: 10, day: 14),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    239523493,
                    new DateOnlydateArray2M
                    {
                        Id = 239523493,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 5),

new DateOnly(year: 1974, month: 10, day: 10),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 5),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 19),

new DateOnly(year: 2004, month: 10, day: 2),

new DateOnly(year: 1922, month: 10, day: 5),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    250760014,
                    new DateOnlydateArray2M
                    {
                        Id = 250760014,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1977, month: 10, day: 7),

new DateOnly(year: 1964, month: 10, day: 13),

new DateOnly(year: 1971, month: 10, day: 13),

new DateOnly(year: 2015, month: 10, day: 1),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 474333893,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

}
                        }

                    }
                );

                expected.Add(
                    313784574,
                    new DateOnlydateArray2M
                    {
                        Id = 313784574,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 1),

new DateOnly(year: 2014, month: 10, day: 8),

new DateOnly(year: 1924, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 12),

new DateOnly(year: 1965, month: 10, day: 5),

new DateOnly(year: 1928, month: 10, day: 13),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    416931732,
                    new DateOnlydateArray2M
                    {
                        Id = 416931732,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 7),

new DateOnly(year: 1970, month: 10, day: 5),

new DateOnly(year: 2015, month: 10, day: 1),

new DateOnly(year: 2005, month: 10, day: 19),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 151782977,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

}
                        }

                    }
                );

                expected.Add(
                    419027208,
                    new DateOnlydateArray2M
                    {
                        Id = 419027208,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1997, month: 10, day: 3),

new DateOnly(year: 1937, month: 10, day: 14),

new DateOnly(year: 1958, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 5),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1996, month: 10, day: 11),

new DateOnly(year: 1984, month: 10, day: 9),

new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1986, month: 10, day: 2),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    431511944,
                    new DateOnlydateArray2M
                    {
                        Id = 431511944,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 10),

new DateOnly(year: 2018, month: 10, day: 19),

new DateOnly(year: 2008, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1983, month: 10, day: 1),

new DateOnly(year: 1929, month: 10, day: 11),

new DateOnly(year: 2005, month: 10, day: 9),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    520711680,
                    new DateOnlydateArray2M
                    {
                        Id = 520711680,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1996, month: 10, day: 16),

new DateOnly(year: 1957, month: 10, day: 5),

new DateOnly(year: 1992, month: 10, day: 6),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 378598370,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    542073896,
                    new DateOnlydateArray2M
                    {
                        Id = 542073896,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2018, month: 10, day: 17),

new DateOnly(year: 1999, month: 10, day: 7),

new DateOnly(year: 1959, month: 10, day: 6),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    563997982,
                    new DateOnlydateArray2M
                    {
                        Id = 563997982,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1923, month: 10, day: 10),

new DateOnly(year: 1990, month: 10, day: 5),

new DateOnly(year: 1929, month: 10, day: 13),

new DateOnly(year: 1985, month: 10, day: 17),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1716836921,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    565662533,
                    new DateOnlydateArray2M
                    {
                        Id = 565662533,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1951, month: 10, day: 16),

new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1925, month: 10, day: 13),

new DateOnly(year: 2010, month: 10, day: 2),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1941, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 13),

new DateOnly(year: 1992, month: 10, day: 8),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1297542691,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    610996681,
                    new DateOnlydateArray2M
                    {
                        Id = 610996681,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1920, month: 10, day: 12),

new DateOnly(year: 1949, month: 10, day: 2),

new DateOnly(year: 1929, month: 10, day: 1),

new DateOnly(year: 1927, month: 10, day: 10),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 521115608,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

}
                        }

                    }
                );

                expected.Add(
                    664191186,
                    new DateOnlydateArray2M
                    {
                        Id = 664191186,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1960, month: 10, day: 16),

new DateOnly(year: 1971, month: 10, day: 2),

new DateOnly(year: 1923, month: 10, day: 9),

new DateOnly(year: 1923, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 449048751,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    713510294,
                    new DateOnlydateArray2M
                    {
                        Id = 713510294,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1997, month: 10, day: 19),

new DateOnly(year: 1933, month: 10, day: 3),

new DateOnly(year: 1985, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1955, month: 10, day: 6),

new DateOnly(year: 1997, month: 10, day: 14),

new DateOnly(year: 1983, month: 10, day: 16),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    747175902,
                    new DateOnlydateArray2M
                    {
                        Id = 747175902,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1994, month: 10, day: 14),

new DateOnly(year: 1948, month: 10, day: 6),

new DateOnly(year: 1955, month: 10, day: 16),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 2001, month: 10, day: 8),

new DateOnly(year: 1967, month: 10, day: 8),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    784231727,
                    new DateOnlydateArray2M
                    {
                        Id = 784231727,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2002, month: 10, day: 14),

new DateOnly(year: 1986, month: 10, day: 14),

new DateOnly(year: 1976, month: 10, day: 5),

new DateOnly(year: 1940, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1928, month: 10, day: 17),

new DateOnly(year: 1953, month: 10, day: 11),

new DateOnly(year: 2016, month: 10, day: 11),

new DateOnly(year: 1956, month: 10, day: 17),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1876292561,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

}
                        }

                    }
                );

                expected.Add(
                    893427232,
                    new DateOnlydateArray2M
                    {
                        Id = 893427232,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 1949, month: 10, day: 7),

new DateOnly(year: 1986, month: 10, day: 11),

new DateOnly(year: 1936, month: 10, day: 17),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    982572110,
                    new DateOnlydateArray2M
                    {
                        Id = 982572110,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1999, month: 10, day: 13),

new DateOnly(year: 1987, month: 10, day: 2),

new DateOnly(year: 1941, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1083619520,
                    new DateOnlydateArray2M
                    {
                        Id = 1083619520,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 18),

new DateOnly(year: 1918, month: 10, day: 15),

new DateOnly(year: 1938, month: 10, day: 6),

new DateOnly(year: 1919, month: 10, day: 7),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1981, month: 10, day: 15),

new DateOnly(year: 1957, month: 10, day: 9),

new DateOnly(year: 1974, month: 10, day: 19),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1165487876,
                    new DateOnlydateArray2M
                    {
                        Id = 1165487876,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1934, month: 10, day: 4),

new DateOnly(year: 2004, month: 10, day: 1),

new DateOnly(year: 1933, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1195001246,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1309365022,
                    new DateOnlydateArray2M
                    {
                        Id = 1309365022,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1948, month: 10, day: 5),

new DateOnly(year: 1939, month: 10, day: 5),

new DateOnly(year: 1995, month: 10, day: 3),

new DateOnly(year: 1946, month: 10, day: 6),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 6),

new DateOnly(year: 1958, month: 10, day: 10),

new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1946, month: 10, day: 9),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1302266743,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

},
                            NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

}
                        }

                    }
                );

                expected.Add(
                    1317580269,
                    new DateOnlydateArray2M
                    {
                        Id = 1317580269,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1959, month: 10, day: 4),

new DateOnly(year: 1924, month: 10, day: 11),

new DateOnly(year: 1971, month: 10, day: 4),

new DateOnly(year: 1933, month: 10, day: 15),

},
                        NullableValue = null,

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1069208345,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1346540019,
                    new DateOnlydateArray2M
                    {
                        Id = 1346540019,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1954, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 4),

new DateOnly(year: 1962, month: 10, day: 2),

new DateOnly(year: 1942, month: 10, day: 11),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1347243701,
                    new DateOnlydateArray2M
                    {
                        Id = 1347243701,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1931, month: 10, day: 18),

new DateOnly(year: 1950, month: 10, day: 6),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1978, month: 10, day: 8),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1991, month: 10, day: 19),

new DateOnly(year: 1986, month: 10, day: 6),

new DateOnly(year: 1976, month: 10, day: 12),

new DateOnly(year: 1955, month: 10, day: 10),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 207362866,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1779889922,
                    new DateOnlydateArray2M
                    {
                        Id = 1779889922,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2014, month: 10, day: 16),

new DateOnly(year: 1950, month: 10, day: 15),

new DateOnly(year: 1964, month: 10, day: 8),

new DateOnly(year: 2010, month: 10, day: 8),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1940, month: 10, day: 4),

new DateOnly(year: 1991, month: 10, day: 10),

new DateOnly(year: 1975, month: 10, day: 6),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 928186054,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1806882227,
                    new DateOnlydateArray2M
                    {
                        Id = 1806882227,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1982, month: 10, day: 8),

new DateOnly(year: 1936, month: 10, day: 3),

new DateOnly(year: 1917, month: 10, day: 15),

new DateOnly(year: 1936, month: 10, day: 5),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1904334101,
                    new DateOnlydateArray2M
                    {
                        Id = 1904334101,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1946, month: 10, day: 19),

new DateOnly(year: 1960, month: 10, day: 5),

new DateOnly(year: 2017, month: 10, day: 2),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 11),

new DateOnly(year: 1969, month: 10, day: 18),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972502120,
                    new DateOnlydateArray2M
                    {
                        Id = 1972502120,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1965, month: 10, day: 15),

new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1918, month: 10, day: 16),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2019, month: 10, day: 4),

new DateOnly(year: 1948, month: 10, day: 11),

new DateOnly(year: 1949, month: 10, day: 16),

new DateOnly(year: 1932, month: 10, day: 13),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2119137426,
                    new DateOnlydateArray2M
                    {
                        Id = 2119137426,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1968, month: 10, day: 7),

new DateOnly(year: 1939, month: 10, day: 11),

new DateOnly(year: 1925, month: 10, day: 12),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1971, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 18),

new DateOnly(year: 1943, month: 10, day: 13),

},

                        ModelInner = new DateOnlydateArray2MI
                        {
                            Id = 1358741182,
                            Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.DateOnly>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_dateonlydatearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DateOnlydateArray2MI),
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

                var expected = new Dictionary<System.Int32,DateOnlydateArray2MI>(15);

                expected.Add(
                    151782977,
                    new DateOnlydateArray2MI
                    {
                        Id = 151782977,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

}
                    }
                );

                expected.Add(
                    207362866,
                    new DateOnlydateArray2MI
                    {
                        Id = 207362866,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    378598370,
                    new DateOnlydateArray2MI
                    {
                        Id = 378598370,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    449048751,
                    new DateOnlydateArray2MI
                    {
                        Id = 449048751,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    474333893,
                    new DateOnlydateArray2MI
                    {
                        Id = 474333893,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

}
                    }
                );

                expected.Add(
                    521115608,
                    new DateOnlydateArray2MI
                    {
                        Id = 521115608,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

}
                    }
                );

                expected.Add(
                    928186054,
                    new DateOnlydateArray2MI
                    {
                        Id = 928186054,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1069208345,
                    new DateOnlydateArray2MI
                    {
                        Id = 1069208345,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1157805165,
                    new DateOnlydateArray2MI
                    {
                        Id = 1157805165,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

}
                    }
                );

                expected.Add(
                    1195001246,
                    new DateOnlydateArray2MI
                    {
                        Id = 1195001246,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1297542691,
                    new DateOnlydateArray2MI
                    {
                        Id = 1297542691,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1302266743,
                    new DateOnlydateArray2MI
                    {
                        Id = 1302266743,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

}
                    }
                );

                expected.Add(
                    1358741182,
                    new DateOnlydateArray2MI
                    {
                        Id = 1358741182,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1716836921,
                    new DateOnlydateArray2MI
                    {
                        Id = 1716836921,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1876292561,
                    new DateOnlydateArray2MI
                    {
                        Id = 1876292561,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

}
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

                var expected = new Dictionary<System.Int32,DateOnlydateArray2MI>(15);

                expected.Add(
                    151782977,
                    new DateOnlydateArray2MI
                    {
                        Id = 151782977,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1924, month: 10, day: 13),

new DateOnly(year: 1949, month: 10, day: 4),

new DateOnly(year: 1953, month: 10, day: 4),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1921, month: 10, day: 9),

new DateOnly(year: 2005, month: 10, day: 8),

new DateOnly(year: 1921, month: 10, day: 11),

new DateOnly(year: 1961, month: 10, day: 13),

}
                    }
                );

                expected.Add(
                    207362866,
                    new DateOnlydateArray2MI
                    {
                        Id = 207362866,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1947, month: 10, day: 3),

new DateOnly(year: 1942, month: 10, day: 14),

new DateOnly(year: 1935, month: 10, day: 17),

new DateOnly(year: 1984, month: 10, day: 10),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    378598370,
                    new DateOnlydateArray2MI
                    {
                        Id = 378598370,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1952, month: 10, day: 15),

new DateOnly(year: 1921, month: 10, day: 5),

new DateOnly(year: 1984, month: 10, day: 13),

new DateOnly(year: 1932, month: 10, day: 6),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    449048751,
                    new DateOnlydateArray2MI
                    {
                        Id = 449048751,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1963, month: 10, day: 12),

new DateOnly(year: 2000, month: 10, day: 18),

new DateOnly(year: 1969, month: 10, day: 9),

new DateOnly(year: 1946, month: 10, day: 1),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    474333893,
                    new DateOnlydateArray2MI
                    {
                        Id = 474333893,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2007, month: 10, day: 5),

new DateOnly(year: 1964, month: 10, day: 1),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1944, month: 10, day: 17),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1992, month: 10, day: 5),

new DateOnly(year: 1926, month: 10, day: 12),

new DateOnly(year: 1969, month: 10, day: 4),

new DateOnly(year: 1981, month: 10, day: 18),

}
                    }
                );

                expected.Add(
                    521115608,
                    new DateOnlydateArray2MI
                    {
                        Id = 521115608,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2003, month: 10, day: 4),

new DateOnly(year: 1949, month: 10, day: 8),

new DateOnly(year: 1955, month: 10, day: 18),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1989, month: 10, day: 13),

new DateOnly(year: 1975, month: 10, day: 8),

new DateOnly(year: 1980, month: 10, day: 3),

}
                    }
                );

                expected.Add(
                    928186054,
                    new DateOnlydateArray2MI
                    {
                        Id = 928186054,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1980, month: 10, day: 11),

new DateOnly(year: 1981, month: 10, day: 4),

new DateOnly(year: 1952, month: 10, day: 11),

new DateOnly(year: 1919, month: 10, day: 11),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1069208345,
                    new DateOnlydateArray2MI
                    {
                        Id = 1069208345,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1944, month: 10, day: 17),

new DateOnly(year: 1975, month: 10, day: 16),

new DateOnly(year: 1989, month: 10, day: 11),

new DateOnly(year: 2006, month: 10, day: 18),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1157805165,
                    new DateOnlydateArray2MI
                    {
                        Id = 1157805165,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2018, month: 10, day: 12),

new DateOnly(year: 1917, month: 10, day: 6),

new DateOnly(year: 1978, month: 10, day: 2),

new DateOnly(year: 1948, month: 10, day: 10),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 1965, month: 10, day: 19),

new DateOnly(year: 1991, month: 10, day: 7),

new DateOnly(year: 2015, month: 10, day: 5),

new DateOnly(year: 2018, month: 10, day: 8),

}
                    }
                );

                expected.Add(
                    1195001246,
                    new DateOnlydateArray2MI
                    {
                        Id = 1195001246,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(4)
{
new DateOnly(year: 2001, month: 10, day: 11),

new DateOnly(year: 1994, month: 10, day: 6),

new DateOnly(year: 1928, month: 10, day: 10),

new DateOnly(year: 1954, month: 10, day: 3),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1297542691,
                    new DateOnlydateArray2MI
                    {
                        Id = 1297542691,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2014, month: 10, day: 11),

new DateOnly(year: 1938, month: 10, day: 18),

new DateOnly(year: 1920, month: 10, day: 15),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1302266743,
                    new DateOnlydateArray2MI
                    {
                        Id = 1302266743,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2006, month: 10, day: 16),

new DateOnly(year: 1996, month: 10, day: 1),

new DateOnly(year: 1918, month: 10, day: 15),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 2019, month: 10, day: 15),

new DateOnly(year: 1935, month: 10, day: 3),

new DateOnly(year: 1964, month: 10, day: 4),

}
                    }
                );

                expected.Add(
                    1358741182,
                    new DateOnlydateArray2MI
                    {
                        Id = 1358741182,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1995, month: 10, day: 13),

new DateOnly(year: 1976, month: 10, day: 19),

new DateOnly(year: 1956, month: 10, day: 18),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1716836921,
                    new DateOnlydateArray2MI
                    {
                        Id = 1716836921,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1991, month: 10, day: 5),

new DateOnly(year: 1985, month: 10, day: 12),

new DateOnly(year: 1992, month: 10, day: 9),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1876292561,
                    new DateOnlydateArray2MI
                    {
                        Id = 1876292561,
                        Value = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1925, month: 10, day: 7),

new DateOnly(year: 1969, month: 10, day: 2),

new DateOnly(year: 1967, month: 10, day: 3),

},
                        NullableValue = 
new System.Collections.Generic.List<System.DateOnly>(3)
{
new DateOnly(year: 1959, month: 10, day: 5),

new DateOnly(year: 1986, month: 10, day: 5),

new DateOnly(year: 1943, month: 10, day: 13),

}
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

