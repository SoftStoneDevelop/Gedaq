

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
    internal partial interface ITimeSpanListintervalArray
    {
    }
    
    internal partial class TimeSpanListintervalArray : ITimeSpanListintervalArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2mi(
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
            asPartInterface: typeof(ITimeSpanListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2mi(
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
            queryMapType: typeof(TimeSpanintervalArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModelInner(connection, 1005869626, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModelInner(connection, 142368195, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelInnerAsync(connection, 150132429, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelInnerAsync(connection, 528181804, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                id =  ((ITimeSpanListintervalArray)this).InsertModelInnerReturning(connection, 940144489, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

}, null);
                Assert.That(id, Is.EqualTo(940144489));

                id =  ((ITimeSpanListintervalArray)this).InsertModelInnerReturning(connection, 1431949342, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

});
                Assert.That(id, Is.EqualTo(1431949342));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 1684531514, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

}, null);
                Assert.That(id, Is.EqualTo(1684531514));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 2106227318, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

}, null);
                Assert.That(id, Is.EqualTo(2106227318));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 1872772220, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

});
                Assert.That(id, Is.EqualTo(1872772220));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 1364554629, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

});
                Assert.That(id, Is.EqualTo(1364554629));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 1853390512, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

});
                Assert.That(id, Is.EqualTo(1853390512));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 2134238359, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

});
                Assert.That(id, Is.EqualTo(2134238359));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 679746324, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

});
                Assert.That(id, Is.EqualTo(679746324));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 814707986, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

});
                Assert.That(id, Is.EqualTo(814707986));

                id = await ((ITimeSpanListintervalArray)this).InsertModelInnerReturningAsync(connection, 646515623, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

});
                Assert.That(id, Is.EqualTo(646515623));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2m(
	id,
    value,
    nullablevalue,
    timespanintervalarray2mi_id
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
            asPartInterface: typeof(ITimeSpanListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray2mi_id", 
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

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModel(connection, 1247032649, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanListintervalArray)this).InsertModel(connection, 1638590324, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

}, null, 1005869626);
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

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelAsync(connection, 139864404, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanListintervalArray)this).InsertModelAsync(connection, 333184914, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

}, null, 142368195);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray2m(
	id,
    value,
    nullablevalue,
    timespanintervalarray2mi_id
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
    timespanintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeSpanintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeSpan>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalarray2mi_id", 
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
                List<TimeSpanintervalArray2M> models = null;
                TimeSpanintervalArray2M model = null;

                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, 919162704, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, 1074881761, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

}, 150132429).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, 1925507969, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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

                models =  ((ITimeSpanListintervalArray)this).InsertModelReturning(connection, 1764935115, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

}, 528181804).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray2M> models = null;
                TimeSpanintervalArray2M model = null;

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1013472314, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1424971381, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

}, null, 940144489).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1196988414, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 283589417, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

}, 1431949342).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1722374701, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 70600473, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

}, 1684531514).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1830528129, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1045694216, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

}, null, 2106227318).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 975169430, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1984857567, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

}, null, 1872772220).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1311309115, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1510790874, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

}, null, 1364554629).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 568333575, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1681320832, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

}, null, 1853390512).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 838842173, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 521597399, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

}, 2134238359).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 431566615, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 844877539, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

}, null, 679746324).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 282213430, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1275075404, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

}, null, 814707986).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 265024990, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

}, 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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

                models = await ((ITimeSpanListintervalArray)this).InsertModelReturningAsync(connection, 1510090114, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

}, 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

}, 646515623).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)
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
                var models =  ((ITimeSpanListintervalArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                var models = await ((ITimeSpanListintervalArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
FROM public.timespanintervalarray2m m
LEFT JOIN public.timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanListintervalArray)
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
                var models =  ((ITimeSpanListintervalArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                var models = await ((ITimeSpanListintervalArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                 using var cmd =  ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 838842173);
                var models =  ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(20));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

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
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

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
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

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
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

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
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                await using var cmd = await ((ITimeSpanListintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1510090114);
                var models = await ((ITimeSpanListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(8));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

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
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

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
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

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
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
            asPartInterface: typeof(ITimeSpanListintervalArray)
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
                 foreach(var batchResult in ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatch(connection, 283589417, 844877539))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

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
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

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
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

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
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

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
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

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
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                await foreach(var batchResult in ((ITimeSpanListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 1830528129, 1722374701))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
COPY public.binary_timespanintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
FROM public.binary_timespanintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MI),
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

                var importCollection = new List<TimeSpanintervalArray2MI>(7);

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 142368195,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 150132429,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 528181804,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 646515623,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 679746324,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 814707986,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 940144489,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142368195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(150132429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528181804));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(646515623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(679746324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

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
                Assert.That(model.Id, Is.EqualTo(814707986));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

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
                Assert.That(model.Id, Is.EqualTo(940144489));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                new TimeSpanintervalArray2MI
                {
                    Id = 1005869626,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 1364554629,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 1431949342,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 1684531514,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 1853390512,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 1872772220,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

}
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 2106227318,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeSpanintervalArray2MI
                {
                    Id = 2134238359,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142368195));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(150132429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(528181804));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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
                Assert.That(model.Id, Is.EqualTo(646515623));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(679746324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

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
                Assert.That(model.Id, Is.EqualTo(814707986));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

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
                Assert.That(model.Id, Is.EqualTo(940144489));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1005869626));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1364554629));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

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
                Assert.That(model.Id, Is.EqualTo(1431949342));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1684531514));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(1853390512));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

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
                Assert.That(model.Id, Is.EqualTo(1872772220));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
                Assert.That(model.Id, Is.EqualTo(2106227318));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(2134238359));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
COPY public.binary_timespanintervalarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
FROM public.binary_timespanintervalarray2m m
LEFT JOIN public.binary_timespanintervalarray2mi mi ON mi.id = m.timespanintervalarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
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

                var importCollection = new List<TimeSpanintervalArray2M>(15);

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 70600473,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1684531514
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 139864404,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 265024990,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 282213430,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 283589417,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1431949342
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 333184914,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 142368195
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 431566615,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 521597399,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 2134238359
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 568333575,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 838842173,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 844877539,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 679746324
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 919162704,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 975169430,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1013472314,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1045694216,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 2106227318
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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

                importCollection.Clear();

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1074881761,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 150132429
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1196988414,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1247032649,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1275075404,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 814707986
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1311309115,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1424971381,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 940144489
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1510090114,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 646515623
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1510790874,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1364554629
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1638590324,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1005869626
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1681320832,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1853390512
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1722374701,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1764935115,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

},

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 528181804
                    }

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1830528129,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1925507969,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeSpanintervalArray2M
                {
                    Id = 1984857567,
                    Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

},
                    NullableValue = null,

                    ModelInner = new TimeSpanintervalArray2MI 
                    {
                        Id = 1872772220
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70600473));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1684531514));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

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
                Assert.That(model.Id, Is.EqualTo(139864404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

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
                Assert.That(model.Id, Is.EqualTo(265024990));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

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
                Assert.That(model.Id, Is.EqualTo(282213430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

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
                Assert.That(model.Id, Is.EqualTo(283589417));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431949342));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

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
                Assert.That(model.Id, Is.EqualTo(333184914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(142368195));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

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
                Assert.That(model.Id, Is.EqualTo(431566615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

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
                Assert.That(model.Id, Is.EqualTo(521597399));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2134238359));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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
                Assert.That(model.Id, Is.EqualTo(568333575));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

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
                Assert.That(model.Id, Is.EqualTo(838842173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

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
                Assert.That(model.Id, Is.EqualTo(844877539));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(679746324));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919162704));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

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


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(975169430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

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
                Assert.That(model.Id, Is.EqualTo(1013472314));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

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
                Assert.That(model.Id, Is.EqualTo(1045694216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2106227318));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

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
                Assert.That(model.Id, Is.EqualTo(1074881761));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(150132429));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

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
                Assert.That(model.Id, Is.EqualTo(1196988414));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

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
                Assert.That(model.Id, Is.EqualTo(1247032649));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

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
                Assert.That(model.Id, Is.EqualTo(1275075404));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(814707986));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1311309115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

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
                Assert.That(model.Id, Is.EqualTo(1424971381));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(940144489));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

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
                Assert.That(model.Id, Is.EqualTo(1510090114));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(646515623));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

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
                Assert.That(model.Id, Is.EqualTo(1510790874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1364554629));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1638590324));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1005869626));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1681320832));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853390512));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

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
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1722374701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

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
                Assert.That(model.Id, Is.EqualTo(1764935115));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(528181804));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

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


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830528129));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

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


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925507969));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

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


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1984857567));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872772220));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

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
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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
COPY public.binary_timespanintervalarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeSpanintervalArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray2M>(30);

                expected.Add(
                    70600473,
                    new TimeSpanintervalArray2M
                    {
                        Id = 70600473,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1684531514,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    139864404,
                    new TimeSpanintervalArray2M
                    {
                        Id = 139864404,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    265024990,
                    new TimeSpanintervalArray2M
                    {
                        Id = 265024990,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    282213430,
                    new TimeSpanintervalArray2M
                    {
                        Id = 282213430,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    283589417,
                    new TimeSpanintervalArray2M
                    {
                        Id = 283589417,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1431949342,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

}
                        }

                    }
                );

                expected.Add(
                    333184914,
                    new TimeSpanintervalArray2M
                    {
                        Id = 333184914,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 142368195,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    431566615,
                    new TimeSpanintervalArray2M
                    {
                        Id = 431566615,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    521597399,
                    new TimeSpanintervalArray2M
                    {
                        Id = 521597399,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 2134238359,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

}
                        }

                    }
                );

                expected.Add(
                    568333575,
                    new TimeSpanintervalArray2M
                    {
                        Id = 568333575,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    838842173,
                    new TimeSpanintervalArray2M
                    {
                        Id = 838842173,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    844877539,
                    new TimeSpanintervalArray2M
                    {
                        Id = 844877539,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 679746324,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

}
                        }

                    }
                );

                expected.Add(
                    919162704,
                    new TimeSpanintervalArray2M
                    {
                        Id = 919162704,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    975169430,
                    new TimeSpanintervalArray2M
                    {
                        Id = 975169430,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1013472314,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1013472314,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045694216,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1045694216,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 2106227318,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1074881761,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1074881761,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 150132429,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

}
                        }

                    }
                );

                expected.Add(
                    1196988414,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1196988414,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1247032649,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1247032649,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1275075404,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1275075404,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 814707986,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

}
                        }

                    }
                );

                expected.Add(
                    1311309115,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1311309115,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1424971381,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1424971381,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 940144489,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1510090114,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1510090114,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 646515623,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

}
                        }

                    }
                );

                expected.Add(
                    1510790874,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1510790874,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1364554629,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

}
                        }

                    }
                );

                expected.Add(
                    1638590324,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1638590324,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1005869626,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

}
                        }

                    }
                );

                expected.Add(
                    1681320832,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1681320832,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1853390512,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

}
                        }

                    }
                );

                expected.Add(
                    1722374701,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1722374701,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1764935115,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1764935115,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 528181804,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1830528129,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1830528129,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1925507969,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1925507969,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1984857567,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1984857567,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1872772220,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray2M>(30);

                expected.Add(
                    70600473,
                    new TimeSpanintervalArray2M
                    {
                        Id = 70600473,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 40, milliseconds: 119),

new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 5, milliseconds: 987),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 17, milliseconds: 629),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 28, milliseconds: 350),

new TimeSpan(days: 0, hours: 10, minutes: 15, seconds: 4, milliseconds: 354),

new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 27, milliseconds: 180),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1684531514,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    139864404,
                    new TimeSpanintervalArray2M
                    {
                        Id = 139864404,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 48, seconds: 46, milliseconds: 983),

new TimeSpan(days: 0, hours: 13, minutes: 2, seconds: 45, milliseconds: 827),

new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 54, milliseconds: 172),

new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 13, milliseconds: 491),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    265024990,
                    new TimeSpanintervalArray2M
                    {
                        Id = 265024990,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 41, seconds: 45, milliseconds: 772),

new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 15, milliseconds: 489),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 22, milliseconds: 506),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 49, seconds: 32, milliseconds: 803),

new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 8, milliseconds: 45),

new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 44, milliseconds: 529),

new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 4, milliseconds: 69),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    282213430,
                    new TimeSpanintervalArray2M
                    {
                        Id = 282213430,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 27, milliseconds: 588),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 18, milliseconds: 822),

new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 50, milliseconds: 310),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 45, seconds: 49, milliseconds: 16),

new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 53, milliseconds: 756),

new TimeSpan(days: 0, hours: 19, minutes: 35, seconds: 3, milliseconds: 157),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    283589417,
                    new TimeSpanintervalArray2M
                    {
                        Id = 283589417,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 55, milliseconds: 869),

new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 45, milliseconds: 97),

new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 23, milliseconds: 531),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 3, milliseconds: 170),

new TimeSpan(days: 0, hours: 5, minutes: 22, seconds: 45, milliseconds: 673),

new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 37, milliseconds: 504),

new TimeSpan(days: 0, hours: 16, minutes: 7, seconds: 17, milliseconds: 6),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1431949342,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

}
                        }

                    }
                );

                expected.Add(
                    333184914,
                    new TimeSpanintervalArray2M
                    {
                        Id = 333184914,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 18, milliseconds: 116),

new TimeSpan(days: 0, hours: 13, minutes: 50, seconds: 53, milliseconds: 126),

new TimeSpan(days: 0, hours: 21, minutes: 9, seconds: 43, milliseconds: 515),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 142368195,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    431566615,
                    new TimeSpanintervalArray2M
                    {
                        Id = 431566615,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 36, seconds: 22, milliseconds: 63),

new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 37, milliseconds: 931),

new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 56, milliseconds: 371),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 43, seconds: 2, milliseconds: 917),

new TimeSpan(days: 0, hours: 19, minutes: 24, seconds: 3, milliseconds: 258),

new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 51, milliseconds: 326),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    521597399,
                    new TimeSpanintervalArray2M
                    {
                        Id = 521597399,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 54, seconds: 39, milliseconds: 111),

new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 10, milliseconds: 193),

new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 16, milliseconds: 839),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 19, minutes: 33, seconds: 18, milliseconds: 574),

new TimeSpan(days: 0, hours: 6, minutes: 43, seconds: 56, milliseconds: 723),

new TimeSpan(days: 0, hours: 5, minutes: 20, seconds: 29, milliseconds: 888),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 2134238359,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

}
                        }

                    }
                );

                expected.Add(
                    568333575,
                    new TimeSpanintervalArray2M
                    {
                        Id = 568333575,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 11, minutes: 36, seconds: 16, milliseconds: 151),

new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 5, milliseconds: 548),

new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 18, milliseconds: 528),

new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 11, milliseconds: 679),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    838842173,
                    new TimeSpanintervalArray2M
                    {
                        Id = 838842173,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 26, milliseconds: 906),

new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 35, milliseconds: 134),

new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 46, milliseconds: 250),

new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 40, milliseconds: 19),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    844877539,
                    new TimeSpanintervalArray2M
                    {
                        Id = 844877539,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 20, minutes: 25, seconds: 53, milliseconds: 647),

new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 596),

new TimeSpan(days: 0, hours: 14, minutes: 7, seconds: 52, milliseconds: 277),

new TimeSpan(days: 0, hours: 9, minutes: 44, seconds: 10, milliseconds: 618),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 679746324,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

}
                        }

                    }
                );

                expected.Add(
                    919162704,
                    new TimeSpanintervalArray2M
                    {
                        Id = 919162704,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 7, minutes: 38, seconds: 51, milliseconds: 531),

new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 40, milliseconds: 890),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 678),

new TimeSpan(days: 0, hours: 17, minutes: 54, seconds: 13, milliseconds: 374),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    975169430,
                    new TimeSpanintervalArray2M
                    {
                        Id = 975169430,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 12, milliseconds: 680),

new TimeSpan(days: 0, hours: 20, minutes: 48, seconds: 16, milliseconds: 866),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 37, milliseconds: 984),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1013472314,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1013472314,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 0, milliseconds: 735),

new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 47, milliseconds: 950),

new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 23, milliseconds: 652),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 10, milliseconds: 79),

new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 55, milliseconds: 225),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 50, milliseconds: 631),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045694216,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1045694216,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 40, milliseconds: 103),

new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 43, milliseconds: 439),

new TimeSpan(days: 0, hours: 8, minutes: 54, seconds: 18, milliseconds: 488),

new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 8, milliseconds: 25),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 2106227318,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1074881761,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1074881761,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 21, minutes: 49, seconds: 0, milliseconds: 604),

new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 1, milliseconds: 136),

new TimeSpan(days: 0, hours: 4, minutes: 27, seconds: 19, milliseconds: 707),

new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 54, milliseconds: 430),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 10, seconds: 22, milliseconds: 91),

new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 12, milliseconds: 84),

new TimeSpan(days: 0, hours: 19, minutes: 37, seconds: 39, milliseconds: 148),

new TimeSpan(days: 0, hours: 7, minutes: 26, seconds: 52, milliseconds: 11),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 150132429,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

}
                        }

                    }
                );

                expected.Add(
                    1196988414,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1196988414,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 6, minutes: 41, seconds: 30, milliseconds: 493),

new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 1, milliseconds: 862),

new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 26, milliseconds: 540),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 19, milliseconds: 402),

new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 41, milliseconds: 984),

new TimeSpan(days: 0, hours: 10, minutes: 20, seconds: 33, milliseconds: 784),

new TimeSpan(days: 0, hours: 2, minutes: 20, seconds: 15, milliseconds: 867),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1247032649,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1247032649,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 21, milliseconds: 759),

new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 44, milliseconds: 193),

new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 25, milliseconds: 571),

new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 45, milliseconds: 442),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 34, milliseconds: 619),

new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 582),

new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 9, milliseconds: 628),

new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 30, milliseconds: 294),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1275075404,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1275075404,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 7, milliseconds: 555),

new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 6, milliseconds: 899),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 39, milliseconds: 545),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 814707986,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

}
                        }

                    }
                );

                expected.Add(
                    1311309115,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1311309115,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 38, milliseconds: 986),

new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 49, milliseconds: 920),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 38, milliseconds: 188),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1424971381,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1424971381,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 9, seconds: 43, milliseconds: 57),

new TimeSpan(days: 0, hours: 19, minutes: 36, seconds: 34, milliseconds: 990),

new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 53, milliseconds: 428),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 940144489,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1510090114,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1510090114,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 19, milliseconds: 27),

new TimeSpan(days: 0, hours: 8, minutes: 24, seconds: 8, milliseconds: 620),

new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 3, milliseconds: 530),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 8, milliseconds: 555),

new TimeSpan(days: 0, hours: 15, minutes: 13, seconds: 41, milliseconds: 910),

new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 31, milliseconds: 554),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 646515623,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

}
                        }

                    }
                );

                expected.Add(
                    1510790874,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1510790874,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 0, minutes: 46, seconds: 51, milliseconds: 150),

new TimeSpan(days: 0, hours: 6, minutes: 46, seconds: 1, milliseconds: 725),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 747),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1364554629,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

}
                        }

                    }
                );

                expected.Add(
                    1638590324,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1638590324,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 8, minutes: 10, seconds: 13, milliseconds: 763),

new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 30, milliseconds: 843),

new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 56, milliseconds: 179),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1005869626,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

}
                        }

                    }
                );

                expected.Add(
                    1681320832,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1681320832,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 755),

new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 17, milliseconds: 646),

new TimeSpan(days: 0, hours: 20, minutes: 56, seconds: 38, milliseconds: 558),

new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 31, milliseconds: 489),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1853390512,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

}
                        }

                    }
                );

                expected.Add(
                    1722374701,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1722374701,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 45, seconds: 52, milliseconds: 672),

new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 26, milliseconds: 852),

new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 21, milliseconds: 580),

new TimeSpan(days: 0, hours: 0, minutes: 10, seconds: 49, milliseconds: 719),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 54, milliseconds: 890),

new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 30, milliseconds: 913),

new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 28, milliseconds: 951),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1764935115,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1764935115,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 30, seconds: 2, milliseconds: 145),

new TimeSpan(days: 0, hours: 16, minutes: 15, seconds: 51, milliseconds: 248),

new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 18, milliseconds: 317),

new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 15, milliseconds: 103),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 12, milliseconds: 918),

new TimeSpan(days: 0, hours: 4, minutes: 29, seconds: 32, milliseconds: 306),

new TimeSpan(days: 0, hours: 22, minutes: 51, seconds: 47, milliseconds: 369),

},

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 528181804,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1830528129,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1830528129,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 36, milliseconds: 159),

new TimeSpan(days: 0, hours: 2, minutes: 57, seconds: 14, milliseconds: 954),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 20, milliseconds: 248),

new TimeSpan(days: 0, hours: 3, minutes: 17, seconds: 3, milliseconds: 147),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1925507969,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1925507969,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 35, seconds: 8, milliseconds: 758),

new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 8, milliseconds: 35),

new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 19, milliseconds: 70),

new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 38, milliseconds: 210),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1984857567,
                    new TimeSpanintervalArray2M
                    {
                        Id = 1984857567,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 10, minutes: 44, seconds: 55, milliseconds: 928),

new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 54, milliseconds: 612),

new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 19, milliseconds: 951),

},
                        NullableValue = null,

                        ModelInner = new TimeSpanintervalArray2MI
                        {
                            Id = 1872772220,
                            Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeSpan>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeSpanintervalArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray2MI>(15);

                expected.Add(
                    142368195,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 142368195,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    150132429,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 150132429,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

}
                    }
                );

                expected.Add(
                    528181804,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 528181804,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    646515623,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 646515623,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

}
                    }
                );

                expected.Add(
                    679746324,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 679746324,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

}
                    }
                );

                expected.Add(
                    814707986,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 814707986,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

}
                    }
                );

                expected.Add(
                    940144489,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 940144489,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1005869626,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1005869626,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

}
                    }
                );

                expected.Add(
                    1364554629,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1364554629,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

}
                    }
                );

                expected.Add(
                    1431949342,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1431949342,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

}
                    }
                );

                expected.Add(
                    1684531514,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1684531514,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1853390512,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1853390512,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

}
                    }
                );

                expected.Add(
                    1872772220,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1872772220,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

}
                    }
                );

                expected.Add(
                    2106227318,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 2106227318,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2134238359,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 2134238359,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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

                var expected = new Dictionary<System.Int32,TimeSpanintervalArray2MI>(15);

                expected.Add(
                    142368195,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 142368195,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 50, milliseconds: 289),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 30, milliseconds: 403),

new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 7, milliseconds: 639),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    150132429,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 150132429,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 6, seconds: 0, milliseconds: 894),

new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 25, milliseconds: 80),

new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 28, milliseconds: 683),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 17, milliseconds: 426),

new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 49, milliseconds: 548),

new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 35, milliseconds: 845),

new TimeSpan(days: 0, hours: 3, minutes: 3, seconds: 28, milliseconds: 497),

}
                    }
                );

                expected.Add(
                    528181804,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 528181804,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 4, milliseconds: 568),

new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 2, milliseconds: 571),

new TimeSpan(days: 0, hours: 4, minutes: 45, seconds: 36, milliseconds: 376),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    646515623,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 646515623,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 50, milliseconds: 666),

new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 17, milliseconds: 153),

new TimeSpan(days: 0, hours: 16, minutes: 23, seconds: 51, milliseconds: 266),

new TimeSpan(days: 0, hours: 16, minutes: 50, seconds: 12, milliseconds: 721),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 3, minutes: 15, seconds: 21, milliseconds: 447),

new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 35, milliseconds: 602),

new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 31, milliseconds: 673),

new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 9, milliseconds: 368),

}
                    }
                );

                expected.Add(
                    679746324,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 679746324,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 33, milliseconds: 284),

new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 29, milliseconds: 561),

new TimeSpan(days: 0, hours: 21, minutes: 13, seconds: 52, milliseconds: 332),

new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 14, milliseconds: 695),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 32, seconds: 33, milliseconds: 492),

new TimeSpan(days: 0, hours: 2, minutes: 54, seconds: 38, milliseconds: 515),

new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 21, milliseconds: 429),

new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 21, milliseconds: 763),

}
                    }
                );

                expected.Add(
                    814707986,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 814707986,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 15, milliseconds: 455),

new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 5, milliseconds: 849),

new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 52, milliseconds: 437),

new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 36, milliseconds: 279),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 3, milliseconds: 449),

new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 44, milliseconds: 266),

new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 31, milliseconds: 109),

}
                    }
                );

                expected.Add(
                    940144489,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 940144489,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 5, minutes: 18, seconds: 56, milliseconds: 50),

new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 44, milliseconds: 712),

new TimeSpan(days: 0, hours: 17, minutes: 8, seconds: 54, milliseconds: 273),

new TimeSpan(days: 0, hours: 1, minutes: 57, seconds: 9, milliseconds: 141),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1005869626,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1005869626,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 4, minutes: 34, seconds: 57, milliseconds: 676),

new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 21, milliseconds: 547),

new TimeSpan(days: 0, hours: 13, minutes: 52, seconds: 51, milliseconds: 495),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 58, seconds: 38, milliseconds: 633),

new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 9, milliseconds: 37),

new TimeSpan(days: 0, hours: 20, minutes: 7, seconds: 7, milliseconds: 550),

}
                    }
                );

                expected.Add(
                    1364554629,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1364554629,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 42, milliseconds: 449),

new TimeSpan(days: 0, hours: 11, minutes: 38, seconds: 39, milliseconds: 70),

new TimeSpan(days: 0, hours: 3, minutes: 12, seconds: 51, milliseconds: 956),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 51, milliseconds: 739),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 46, milliseconds: 330),

new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 23, milliseconds: 762),

}
                    }
                );

                expected.Add(
                    1431949342,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1431949342,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 21, milliseconds: 27),

new TimeSpan(days: 0, hours: 21, minutes: 45, seconds: 5, milliseconds: 487),

new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 53, milliseconds: 813),

new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 24, milliseconds: 899),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 8, milliseconds: 380),

new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 24, milliseconds: 62),

new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 40, milliseconds: 890),

}
                    }
                );

                expected.Add(
                    1684531514,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1684531514,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 23, milliseconds: 90),

new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 95),

new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 20),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1853390512,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1853390512,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 15, milliseconds: 953),

new TimeSpan(days: 0, hours: 18, minutes: 42, seconds: 1, milliseconds: 161),

new TimeSpan(days: 0, hours: 1, minutes: 45, seconds: 25, milliseconds: 337),

new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 54, milliseconds: 675),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 1, milliseconds: 423),

new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 51, milliseconds: 682),

new TimeSpan(days: 0, hours: 19, minutes: 16, seconds: 15, milliseconds: 772),

new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 25, milliseconds: 552),

}
                    }
                );

                expected.Add(
                    1872772220,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 1872772220,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 39, milliseconds: 399),

new TimeSpan(days: 0, hours: 21, minutes: 33, seconds: 54, milliseconds: 591),

new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 25, milliseconds: 935),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 16, minutes: 0, seconds: 29, milliseconds: 59),

new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 6, milliseconds: 984),

new TimeSpan(days: 0, hours: 12, minutes: 39, seconds: 27, milliseconds: 712),

}
                    }
                );

                expected.Add(
                    2106227318,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 2106227318,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 12, seconds: 7, milliseconds: 446),

new TimeSpan(days: 0, hours: 0, minutes: 39, seconds: 56, milliseconds: 667),

new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 37, milliseconds: 475),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2134238359,
                    new TimeSpanintervalArray2MI
                    {
                        Id = 2134238359,
                        Value = 
new System.Collections.Generic.List<System.TimeSpan>(4)
{
new TimeSpan(days: 0, hours: 1, minutes: 30, seconds: 43, milliseconds: 315),

new TimeSpan(days: 0, hours: 13, minutes: 18, seconds: 15, milliseconds: 988),

new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 0, milliseconds: 409),

new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 32, milliseconds: 824),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeSpan>(3)
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 26, milliseconds: 205),

new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 41, milliseconds: 980),

new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 38, milliseconds: 451),

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

