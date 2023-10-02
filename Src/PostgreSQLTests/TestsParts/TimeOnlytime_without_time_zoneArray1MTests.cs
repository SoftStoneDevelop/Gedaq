

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
    internal partial interface ITimeOnlyArraytime_without_time_zoneArray
    {
    }
    
    internal partial class TimeOnlyArraytime_without_time_zoneArray : ITimeOnlyArraytime_without_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1mi(
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1mi(
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInner(connection, 1425662202, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInner(connection, 1523067753, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 30869223, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1762605710, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

});
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

                id =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 612763662, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

});
                Assert.That(id, Is.EqualTo(612763662));

                id =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 355213206, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

});
                Assert.That(id, Is.EqualTo(355213206));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1923386190, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

}, null);
                Assert.That(id, Is.EqualTo(1923386190));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2032322904, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

}, null);
                Assert.That(id, Is.EqualTo(2032322904));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1193221907, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

});
                Assert.That(id, Is.EqualTo(1193221907));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 368971421, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

});
                Assert.That(id, Is.EqualTo(368971421));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1498047582, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

});
                Assert.That(id, Is.EqualTo(1498047582));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1354088626, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

});
                Assert.That(id, Is.EqualTo(1354088626));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1222913888, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

});
                Assert.That(id, Is.EqualTo(1222913888));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 870089961, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

});
                Assert.That(id, Is.EqualTo(870089961));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 599148097, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

});
                Assert.That(id, Is.EqualTo(599148097));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray1mi_id
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray1mi_id", 
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

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModel(connection, 844984323, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModel(connection, 1419804986, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

}, null, 1425662202);
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

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelAsync(connection, 2088882750, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelAsync(connection, 483470668, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

}, 1523067753);
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
INSERT INTO public.timeonlytime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray1mi_id
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
    timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray1mi_id", 
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
                List<TimeOnlytime_without_time_zoneArray1M> models = null;
                TimeOnlytime_without_time_zoneArray1M model = null;

                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 361037607, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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

                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 1087093285, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

}, null, 30869223).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 453032372, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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

                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, 57077756, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

}, null, 1762605710).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneArray1M> models = null;
                TimeOnlytime_without_time_zoneArray1M model = null;

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2098184984, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1813883888, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

}, null, 612763662).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1915298639, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 799595667, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

}, null, 355213206).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1766671208, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 419694496, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

}, 1923386190).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 841167074, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1410142289, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

}, 2032322904).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1590261056, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 25108235, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

}, 1193221907).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 830720226, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1771551233, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

}, 368971421).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 396036255, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1313723438, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

}, null, 1498047582).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 777312427, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2086863749, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

}, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

}, 1354088626).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 17651490, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1514311731, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

}, 1222913888).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1273779422, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1046630400, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

}, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

}, 870089961).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 362121751, 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1122613163, 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

}, null, 599148097).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
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
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
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
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 2086863749);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 844984323);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)
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
                 foreach(var batchResult in ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 1915298639, 57077756))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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
                await foreach(var batchResult in ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 1771551233, 483470668))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(21));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
FROM public.binary_timeonlytime_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MI),
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

                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MI>(7);

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 30869223,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 355213206,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 368971421,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 599148097,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 612763662,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 870089961,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1193221907,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30869223));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(355213206));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(368971421));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(599148097));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(612763662));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(870089961));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1193221907));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1222913888,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1354088626,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1425662202,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1498047582,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1523067753,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1762605710,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 1923386190,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1MI
                {
                    Id = 2032322904,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(30869223));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(355213206));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(368971421));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(599148097));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(612763662));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

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
                Assert.That(model.Id, Is.EqualTo(870089961));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1193221907));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(1222913888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1354088626));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(1425662202));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1498047582));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1523067753));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

};
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
                Assert.That(model.Id, Is.EqualTo(1762605710));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(1923386190));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

};
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
                Assert.That(model.Id, Is.EqualTo(2032322904));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

};
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
COPY public.binary_timeonlytime_without_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
FROM public.binary_timeonlytime_without_time_zonearray1m m
LEFT JOIN public.binary_timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
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

                var importCollection = new List<TimeOnlytime_without_time_zoneArray1M>(15);

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 17651490,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 25108235,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1193221907
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 57077756,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1762605710
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 361037607,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 362121751,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 396036255,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 419694496,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1923386190
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 453032372,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 483470668,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1523067753
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 777312427,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 799595667,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 355213206
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 830720226,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 841167074,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 844984323,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1046630400,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 870089961
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                importCollection.Clear();

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1087093285,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 30869223
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1122613163,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 599148097
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1273779422,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1313723438,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1498047582
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1410142289,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 2032322904
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1419804986,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1425662202
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1514311731,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

},
                    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1222913888
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1590261056,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1766671208,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1771551233,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 368971421
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1813883888,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 612763662
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 1915298639,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 2086863749,
                    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

},
                    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray1MI 
                    {
                        Id = 1354088626
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 2088882750,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray1M
                {
                    Id = 2098184984,
                    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(17651490));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

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
                Assert.That(model.Id, Is.EqualTo(25108235));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1193221907));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

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
                Assert.That(model.Id, Is.EqualTo(57077756));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1762605710));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

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
                Assert.That(model.Id, Is.EqualTo(361037607));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

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
                Assert.That(model.Id, Is.EqualTo(362121751));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

};
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
                Assert.That(model.Id, Is.EqualTo(396036255));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

};
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
                Assert.That(model.Id, Is.EqualTo(419694496));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1923386190));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

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
                Assert.That(model.Id, Is.EqualTo(453032372));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

};
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
                Assert.That(model.Id, Is.EqualTo(483470668));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1523067753));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

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
                Assert.That(model.Id, Is.EqualTo(777312427));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

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
                Assert.That(model.Id, Is.EqualTo(799595667));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(355213206));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

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
                Assert.That(model.Id, Is.EqualTo(830720226));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

};
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
                Assert.That(model.Id, Is.EqualTo(841167074));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

};
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
                Assert.That(model.Id, Is.EqualTo(844984323));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

};
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
                Assert.That(model.Id, Is.EqualTo(1046630400));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(870089961));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

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
                Assert.That(model.Id, Is.EqualTo(1087093285));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(30869223));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

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
                Assert.That(model.Id, Is.EqualTo(1122613163));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(599148097));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

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
                Assert.That(model.Id, Is.EqualTo(1273779422));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

};
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
                Assert.That(model.Id, Is.EqualTo(1313723438));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1498047582));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

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
                Assert.That(model.Id, Is.EqualTo(1410142289));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032322904));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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
                Assert.That(model.Id, Is.EqualTo(1419804986));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1425662202));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

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
                Assert.That(model.Id, Is.EqualTo(1514311731));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1222913888));

                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

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
                Assert.That(model.Id, Is.EqualTo(1590261056));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

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
                Assert.That(model.Id, Is.EqualTo(1766671208));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

};
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
                Assert.That(model.Id, Is.EqualTo(1771551233));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(368971421));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

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
                Assert.That(model.Id, Is.EqualTo(1813883888));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

};
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
                Assert.That(model.ModelInner.Id, Is.EqualTo(612763662));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1915298639));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

};
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
                Assert.That(model.Id, Is.EqualTo(2086863749));
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

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
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354088626));

                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

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
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

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
                Assert.That(model.Id, Is.EqualTo(2088882750));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

};
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
                Assert.That(model.Id, Is.EqualTo(2098184984));
                {
                    var expectEnumerValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

};
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


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray1M>(30);

                expected.Add(
                    17651490,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 17651490,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    25108235,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 25108235,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1193221907,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

}
                        }

                    }
                );

                expected.Add(
                    57077756,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 57077756,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1762605710,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

}
                        }

                    }
                );

                expected.Add(
                    361037607,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 361037607,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    362121751,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 362121751,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    396036255,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 396036255,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    419694496,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 419694496,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1923386190,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    453032372,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 453032372,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    483470668,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 483470668,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1523067753,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    777312427,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 777312427,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    799595667,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 799595667,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 355213206,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

}
                        }

                    }
                );

                expected.Add(
                    830720226,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 830720226,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    841167074,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 841167074,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    844984323,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 844984323,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1046630400,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1046630400,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 870089961,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

}
                        }

                    }
                );

                expected.Add(
                    1087093285,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1087093285,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 30869223,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

}
                        }

                    }
                );

                expected.Add(
                    1122613163,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1122613163,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 599148097,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

}
                        }

                    }
                );

                expected.Add(
                    1273779422,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1273779422,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1313723438,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1313723438,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1498047582,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

}
                        }

                    }
                );

                expected.Add(
                    1410142289,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1410142289,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 2032322904,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1419804986,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1419804986,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1425662202,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

}
                        }

                    }
                );

                expected.Add(
                    1514311731,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1514311731,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1222913888,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

}
                        }

                    }
                );

                expected.Add(
                    1590261056,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1590261056,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1766671208,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1766671208,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1771551233,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1771551233,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 368971421,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

}
                        }

                    }
                );

                expected.Add(
                    1813883888,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1813883888,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 612763662,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

}
                        }

                    }
                );

                expected.Add(
                    1915298639,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1915298639,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2086863749,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2086863749,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1354088626,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

}
                        }

                    }
                );

                expected.Add(
                    2088882750,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2088882750,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2098184984,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2098184984,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

},
                        NullableValue = null,

                        ModelInner = null

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray1M>(30);

                expected.Add(
                    17651490,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 17651490,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 9, second: 43, millisecond: 213),

new TimeOnly(hour: 1, minute: 2, second: 42, millisecond: 518),

new TimeOnly(hour: 18, minute: 12, second: 40, millisecond: 749),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 603),

new TimeOnly(hour: 2, minute: 55, second: 40, millisecond: 54),

new TimeOnly(hour: 18, minute: 31, second: 22, millisecond: 765),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    25108235,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 25108235,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 26, second: 48, millisecond: 367),

new TimeOnly(hour: 3, minute: 37, second: 18, millisecond: 557),

new TimeOnly(hour: 2, minute: 36, second: 47, millisecond: 746),

new TimeOnly(hour: 9, minute: 56, second: 3, millisecond: 743),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 45, millisecond: 62),

new TimeOnly(hour: 19, minute: 44, second: 26, millisecond: 167),

new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 394),

new TimeOnly(hour: 17, minute: 12, second: 44, millisecond: 739),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1193221907,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

}
                        }

                    }
                );

                expected.Add(
                    57077756,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 57077756,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 24, second: 6, millisecond: 34),

new TimeOnly(hour: 22, minute: 22, second: 21, millisecond: 220),

new TimeOnly(hour: 6, minute: 45, second: 9, millisecond: 483),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1762605710,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

}
                        }

                    }
                );

                expected.Add(
                    361037607,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 361037607,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 16, second: 43, millisecond: 141),

new TimeOnly(hour: 10, minute: 40, second: 57, millisecond: 787),

new TimeOnly(hour: 19, minute: 13, second: 8, millisecond: 72),

new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 452),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 970),

new TimeOnly(hour: 3, minute: 37, second: 27, millisecond: 380),

new TimeOnly(hour: 0, minute: 45, second: 16, millisecond: 366),

new TimeOnly(hour: 17, minute: 50, second: 38, millisecond: 413),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    362121751,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 362121751,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 58, second: 35, millisecond: 781),

new TimeOnly(hour: 19, minute: 50, second: 38, millisecond: 566),

new TimeOnly(hour: 14, minute: 27, second: 1, millisecond: 392),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    396036255,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 396036255,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 47, second: 44, millisecond: 910),

new TimeOnly(hour: 19, minute: 36, second: 14, millisecond: 328),

new TimeOnly(hour: 19, minute: 53, second: 43, millisecond: 183),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    419694496,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 419694496,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 4, second: 28, millisecond: 786),

new TimeOnly(hour: 15, minute: 27, second: 27, millisecond: 440),

new TimeOnly(hour: 8, minute: 15, second: 27, millisecond: 659),

new TimeOnly(hour: 17, minute: 26, second: 1, millisecond: 249),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 26, second: 58, millisecond: 165),

new TimeOnly(hour: 19, minute: 15, second: 31, millisecond: 519),

new TimeOnly(hour: 20, minute: 15, second: 31, millisecond: 197),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1923386190,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    453032372,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 453032372,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 10, second: 42, millisecond: 156),

new TimeOnly(hour: 22, minute: 42, second: 49, millisecond: 712),

new TimeOnly(hour: 18, minute: 4, second: 39, millisecond: 515),

new TimeOnly(hour: 4, minute: 0, second: 10, millisecond: 459),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    483470668,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 483470668,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 21, millisecond: 553),

new TimeOnly(hour: 1, minute: 28, second: 34, millisecond: 886),

new TimeOnly(hour: 1, minute: 41, second: 25, millisecond: 16),

new TimeOnly(hour: 19, minute: 48, second: 1, millisecond: 180),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 44, second: 45, millisecond: 559),

new TimeOnly(hour: 3, minute: 9, second: 42, millisecond: 151),

new TimeOnly(hour: 2, minute: 23, second: 14, millisecond: 315),

new TimeOnly(hour: 8, minute: 36, second: 12, millisecond: 700),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1523067753,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    777312427,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 777312427,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 482),

new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 674),

new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 797),

new TimeOnly(hour: 21, minute: 57, second: 52, millisecond: 580),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 55, second: 40, millisecond: 969),

new TimeOnly(hour: 16, minute: 21, second: 8, millisecond: 447),

new TimeOnly(hour: 7, minute: 19, second: 44, millisecond: 96),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    799595667,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 799595667,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 2, second: 16, millisecond: 26),

new TimeOnly(hour: 18, minute: 42, second: 22, millisecond: 263),

new TimeOnly(hour: 15, minute: 55, second: 39, millisecond: 123),

new TimeOnly(hour: 17, minute: 1, second: 25, millisecond: 506),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 355213206,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

}
                        }

                    }
                );

                expected.Add(
                    830720226,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 830720226,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 33, millisecond: 454),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 495),

new TimeOnly(hour: 21, minute: 0, second: 37, millisecond: 958),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    841167074,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 841167074,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 54, millisecond: 832),

new TimeOnly(hour: 2, minute: 38, second: 24, millisecond: 477),

new TimeOnly(hour: 15, minute: 17, second: 38, millisecond: 504),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    844984323,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 844984323,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 36, second: 58, millisecond: 577),

new TimeOnly(hour: 20, minute: 42, second: 34, millisecond: 626),

new TimeOnly(hour: 12, minute: 13, second: 14, millisecond: 841),

new TimeOnly(hour: 3, minute: 54, second: 19, millisecond: 647),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1046630400,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1046630400,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 41, millisecond: 875),

new TimeOnly(hour: 15, minute: 58, second: 49, millisecond: 391),

new TimeOnly(hour: 19, minute: 31, second: 20, millisecond: 984),

new TimeOnly(hour: 17, minute: 8, second: 15, millisecond: 380),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 41, second: 16, millisecond: 290),

new TimeOnly(hour: 8, minute: 14, second: 23, millisecond: 1),

new TimeOnly(hour: 9, minute: 42, second: 8, millisecond: 52),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 870089961,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

}
                        }

                    }
                );

                expected.Add(
                    1087093285,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1087093285,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 11, second: 15, millisecond: 701),

new TimeOnly(hour: 6, minute: 11, second: 29, millisecond: 890),

new TimeOnly(hour: 18, minute: 5, second: 19, millisecond: 752),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 30869223,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

}
                        }

                    }
                );

                expected.Add(
                    1122613163,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1122613163,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 45, second: 0, millisecond: 504),

new TimeOnly(hour: 21, minute: 32, second: 19, millisecond: 607),

new TimeOnly(hour: 6, minute: 52, second: 32, millisecond: 940),

new TimeOnly(hour: 7, minute: 57, second: 4, millisecond: 180),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 599148097,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

}
                        }

                    }
                );

                expected.Add(
                    1273779422,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1273779422,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 43, second: 48, millisecond: 266),

new TimeOnly(hour: 10, minute: 3, second: 17, millisecond: 152),

new TimeOnly(hour: 13, minute: 18, second: 18, millisecond: 309),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1313723438,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1313723438,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 16, second: 58, millisecond: 322),

new TimeOnly(hour: 16, minute: 50, second: 19, millisecond: 158),

new TimeOnly(hour: 15, minute: 23, second: 12, millisecond: 163),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1498047582,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

}
                        }

                    }
                );

                expected.Add(
                    1410142289,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1410142289,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 33, second: 0, millisecond: 898),

new TimeOnly(hour: 22, minute: 19, second: 5, millisecond: 591),

new TimeOnly(hour: 13, minute: 45, second: 56, millisecond: 665),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 25, millisecond: 106),

new TimeOnly(hour: 12, minute: 39, second: 41, millisecond: 477),

new TimeOnly(hour: 10, minute: 13, second: 49, millisecond: 50),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 2032322904,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1419804986,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1419804986,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 15, millisecond: 931),

new TimeOnly(hour: 5, minute: 39, second: 34, millisecond: 208),

new TimeOnly(hour: 1, minute: 11, second: 22, millisecond: 969),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1425662202,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

}
                        }

                    }
                );

                expected.Add(
                    1514311731,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1514311731,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 36, second: 7, millisecond: 446),

new TimeOnly(hour: 1, minute: 51, second: 48, millisecond: 494),

new TimeOnly(hour: 8, minute: 12, second: 35, millisecond: 253),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 42, second: 50, millisecond: 907),

new TimeOnly(hour: 2, minute: 6, second: 8, millisecond: 217),

new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 740),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1222913888,
                            Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

}
                        }

                    }
                );

                expected.Add(
                    1590261056,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1590261056,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 40, second: 37, millisecond: 939),

new TimeOnly(hour: 15, minute: 58, second: 34, millisecond: 949),

new TimeOnly(hour: 14, minute: 2, second: 26, millisecond: 690),

new TimeOnly(hour: 7, minute: 42, second: 5, millisecond: 298),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 503),

new TimeOnly(hour: 5, minute: 16, second: 8, millisecond: 822),

new TimeOnly(hour: 15, minute: 33, second: 37, millisecond: 581),

new TimeOnly(hour: 1, minute: 14, second: 15, millisecond: 859),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1766671208,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1766671208,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 18, second: 22, millisecond: 261),

new TimeOnly(hour: 6, minute: 36, second: 42, millisecond: 15),

new TimeOnly(hour: 5, minute: 13, second: 4, millisecond: 499),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1771551233,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1771551233,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 38, second: 27, millisecond: 766),

new TimeOnly(hour: 2, minute: 29, second: 2, millisecond: 353),

new TimeOnly(hour: 5, minute: 46, second: 57, millisecond: 51),

new TimeOnly(hour: 4, minute: 45, second: 15, millisecond: 72),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 47, second: 40, millisecond: 517),

new TimeOnly(hour: 21, minute: 46, second: 30, millisecond: 539),

new TimeOnly(hour: 5, minute: 12, second: 10, millisecond: 379),

new TimeOnly(hour: 1, minute: 28, second: 35, millisecond: 406),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 368971421,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

},
                            NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

}
                        }

                    }
                );

                expected.Add(
                    1813883888,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1813883888,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 50, millisecond: 773),

new TimeOnly(hour: 11, minute: 21, second: 9, millisecond: 432),

new TimeOnly(hour: 6, minute: 5, second: 3, millisecond: 535),

new TimeOnly(hour: 18, minute: 22, second: 28, millisecond: 6),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 612763662,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

}
                        }

                    }
                );

                expected.Add(
                    1915298639,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 1915298639,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 50, second: 50, millisecond: 266),

new TimeOnly(hour: 12, minute: 36, second: 19, millisecond: 112),

new TimeOnly(hour: 2, minute: 8, second: 17, millisecond: 341),

new TimeOnly(hour: 5, minute: 45, second: 25, millisecond: 752),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2086863749,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2086863749,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 52, second: 19, millisecond: 794),

new TimeOnly(hour: 20, minute: 34, second: 6, millisecond: 877),

new TimeOnly(hour: 15, minute: 54, second: 0, millisecond: 812),

new TimeOnly(hour: 4, minute: 36, second: 55, millisecond: 595),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 6, second: 26, millisecond: 145),

new TimeOnly(hour: 11, minute: 47, second: 28, millisecond: 892),

new TimeOnly(hour: 22, minute: 18, second: 12, millisecond: 263),

new TimeOnly(hour: 7, minute: 44, second: 34, millisecond: 671),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray1MI
                        {
                            Id = 1354088626,
                            Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

},
                            NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

}
                        }

                    }
                );

                expected.Add(
                    2088882750,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2088882750,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 6, second: 50, millisecond: 175),

new TimeOnly(hour: 18, minute: 30, second: 30, millisecond: 189),

new TimeOnly(hour: 3, minute: 13, second: 51, millisecond: 821),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2098184984,
                    new TimeOnlytime_without_time_zoneArray1M
                    {
                        Id = 2098184984,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 46, second: 26, millisecond: 762),

new TimeOnly(hour: 9, minute: 39, second: 23, millisecond: 856),

new TimeOnly(hour: 22, minute: 27, second: 32, millisecond: 347),

},
                        NullableValue = null,

                        ModelInner = null

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.TimeOnly[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray1MI>(15);

                expected.Add(
                    30869223,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 30869223,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

}
                    }
                );

                expected.Add(
                    355213206,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 355213206,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

}
                    }
                );

                expected.Add(
                    368971421,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 368971421,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

}
                    }
                );

                expected.Add(
                    599148097,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 599148097,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

}
                    }
                );

                expected.Add(
                    612763662,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 612763662,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

}
                    }
                );

                expected.Add(
                    870089961,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 870089961,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

}
                    }
                );

                expected.Add(
                    1193221907,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1193221907,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

}
                    }
                );

                expected.Add(
                    1222913888,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1222913888,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

}
                    }
                );

                expected.Add(
                    1354088626,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1354088626,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

}
                    }
                );

                expected.Add(
                    1425662202,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1425662202,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

}
                    }
                );

                expected.Add(
                    1498047582,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1498047582,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

}
                    }
                );

                expected.Add(
                    1523067753,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1523067753,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762605710,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1762605710,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

}
                    }
                );

                expected.Add(
                    1923386190,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1923386190,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032322904,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 2032322904,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray1MI>(15);

                expected.Add(
                    30869223,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 30869223,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 36, second: 2, millisecond: 408),

new TimeOnly(hour: 9, minute: 55, second: 23, millisecond: 747),

new TimeOnly(hour: 4, minute: 30, second: 55, millisecond: 845),

new TimeOnly(hour: 10, minute: 21, second: 52, millisecond: 308),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 29, second: 44, millisecond: 905),

new TimeOnly(hour: 8, minute: 16, second: 7, millisecond: 265),

new TimeOnly(hour: 9, minute: 45, second: 33, millisecond: 756),

new TimeOnly(hour: 0, minute: 35, second: 45, millisecond: 529),

}
                    }
                );

                expected.Add(
                    355213206,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 355213206,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 19, millisecond: 411),

new TimeOnly(hour: 4, minute: 32, second: 21, millisecond: 423),

new TimeOnly(hour: 2, minute: 43, second: 44, millisecond: 681),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 18, second: 50, millisecond: 524),

new TimeOnly(hour: 16, minute: 44, second: 0, millisecond: 372),

new TimeOnly(hour: 3, minute: 57, second: 10, millisecond: 458),

}
                    }
                );

                expected.Add(
                    368971421,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 368971421,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 57, second: 12, millisecond: 896),

new TimeOnly(hour: 11, minute: 11, second: 21, millisecond: 400),

new TimeOnly(hour: 15, minute: 19, second: 26, millisecond: 951),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 8, second: 8, millisecond: 608),

new TimeOnly(hour: 22, minute: 37, second: 19, millisecond: 871),

new TimeOnly(hour: 4, minute: 51, second: 38, millisecond: 972),

new TimeOnly(hour: 2, minute: 21, second: 49, millisecond: 169),

}
                    }
                );

                expected.Add(
                    599148097,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 599148097,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 55, second: 17, millisecond: 664),

new TimeOnly(hour: 0, minute: 1, second: 35, millisecond: 518),

new TimeOnly(hour: 22, minute: 6, second: 6, millisecond: 110),

new TimeOnly(hour: 14, minute: 10, second: 49, millisecond: 274),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 14, second: 34, millisecond: 256),

new TimeOnly(hour: 8, minute: 55, second: 31, millisecond: 677),

new TimeOnly(hour: 5, minute: 0, second: 22, millisecond: 967),

}
                    }
                );

                expected.Add(
                    612763662,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 612763662,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 41, millisecond: 98),

new TimeOnly(hour: 9, minute: 7, second: 37, millisecond: 631),

new TimeOnly(hour: 4, minute: 42, second: 19, millisecond: 896),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 24, millisecond: 732),

new TimeOnly(hour: 14, minute: 47, second: 16, millisecond: 322),

new TimeOnly(hour: 0, minute: 22, second: 4, millisecond: 316),

}
                    }
                );

                expected.Add(
                    870089961,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 870089961,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 12, second: 30, millisecond: 387),

new TimeOnly(hour: 18, minute: 15, second: 23, millisecond: 111),

new TimeOnly(hour: 10, minute: 49, second: 41, millisecond: 380),

new TimeOnly(hour: 9, minute: 7, second: 56, millisecond: 991),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 57, second: 45, millisecond: 616),

new TimeOnly(hour: 3, minute: 32, second: 8, millisecond: 658),

new TimeOnly(hour: 12, minute: 46, second: 44, millisecond: 782),

}
                    }
                );

                expected.Add(
                    1193221907,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1193221907,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 7, second: 54, millisecond: 474),

new TimeOnly(hour: 19, minute: 29, second: 22, millisecond: 418),

new TimeOnly(hour: 5, minute: 39, second: 48, millisecond: 209),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 11, second: 23, millisecond: 161),

new TimeOnly(hour: 1, minute: 33, second: 32, millisecond: 302),

new TimeOnly(hour: 20, minute: 8, second: 4, millisecond: 385),

}
                    }
                );

                expected.Add(
                    1222913888,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1222913888,
                        Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 52, second: 58, millisecond: 408),

new TimeOnly(hour: 5, minute: 36, second: 40, millisecond: 966),

new TimeOnly(hour: 14, minute: 22, second: 48, millisecond: 191),

new TimeOnly(hour: 11, minute: 36, second: 20, millisecond: 326),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 40, second: 38, millisecond: 984),

new TimeOnly(hour: 16, minute: 1, second: 39, millisecond: 468),

new TimeOnly(hour: 18, minute: 1, second: 0, millisecond: 901),

new TimeOnly(hour: 17, minute: 41, second: 52, millisecond: 111),

}
                    }
                );

                expected.Add(
                    1354088626,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1354088626,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 3, second: 25, millisecond: 468),

new TimeOnly(hour: 3, minute: 40, second: 4, millisecond: 971),

new TimeOnly(hour: 13, minute: 0, second: 53, millisecond: 263),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 37, second: 23, millisecond: 703),

new TimeOnly(hour: 2, minute: 34, second: 56, millisecond: 414),

new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 853),

}
                    }
                );

                expected.Add(
                    1425662202,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1425662202,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 449),

new TimeOnly(hour: 17, minute: 34, second: 33, millisecond: 581),

new TimeOnly(hour: 19, minute: 18, second: 34, millisecond: 670),

},
                        NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 4, second: 19, millisecond: 634),

new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 551),

new TimeOnly(hour: 8, minute: 15, second: 57, millisecond: 683),

new TimeOnly(hour: 15, minute: 12, second: 43, millisecond: 753),

}
                    }
                );

                expected.Add(
                    1498047582,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1498047582,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 0, millisecond: 866),

new TimeOnly(hour: 4, minute: 13, second: 17, millisecond: 552),

new TimeOnly(hour: 2, minute: 48, second: 41, millisecond: 495),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 23, second: 53, millisecond: 211),

new TimeOnly(hour: 1, minute: 10, second: 0, millisecond: 496),

new TimeOnly(hour: 2, minute: 49, second: 44, millisecond: 157),

}
                    }
                );

                expected.Add(
                    1523067753,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1523067753,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 18, second: 34, millisecond: 178),

new TimeOnly(hour: 17, minute: 49, second: 52, millisecond: 619),

new TimeOnly(hour: 8, minute: 5, second: 20, millisecond: 587),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1762605710,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1762605710,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 5, second: 32, millisecond: 33),

new TimeOnly(hour: 14, minute: 57, second: 49, millisecond: 408),

new TimeOnly(hour: 6, minute: 13, second: 4, millisecond: 919),

},
                        NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 34, second: 15, millisecond: 63),

new TimeOnly(hour: 17, minute: 51, second: 27, millisecond: 272),

new TimeOnly(hour: 22, minute: 6, second: 55, millisecond: 584),

}
                    }
                );

                expected.Add(
                    1923386190,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 1923386190,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 22, second: 4, millisecond: 714),

new TimeOnly(hour: 7, minute: 10, second: 27, millisecond: 189),

new TimeOnly(hour: 1, minute: 53, second: 41, millisecond: 267),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2032322904,
                    new TimeOnlytime_without_time_zoneArray1MI
                    {
                        Id = 2032322904,
                        Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 9, second: 19, millisecond: 430),

new TimeOnly(hour: 1, minute: 37, second: 22, millisecond: 626),

new TimeOnly(hour: 0, minute: 52, second: 56, millisecond: 224),

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

