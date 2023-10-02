

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
    internal partial interface ITimeOnlyListtime_without_time_zoneArray
    {
    }
    
    internal partial class TimeOnlyListtime_without_time_zoneArray : ITimeOnlyListtime_without_time_zoneArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2mi(
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
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
INSERT INTO public.timeonlytime_without_time_zonearray2mi(
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
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

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInner(connection, 1903564848, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInner(connection, 468946006, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1177997720, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, 1636900836, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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

                id =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 2032538226, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

}, null);
                Assert.That(id, Is.EqualTo(2032538226));

                id =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, 337971615, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

});
                Assert.That(id, Is.EqualTo(337971615));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1497209963, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

}, null);
                Assert.That(id, Is.EqualTo(1497209963));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 106765264, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

}, null);
                Assert.That(id, Is.EqualTo(106765264));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 918167106, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

});
                Assert.That(id, Is.EqualTo(918167106));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2001866455, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

});
                Assert.That(id, Is.EqualTo(2001866455));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 436880871, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

});
                Assert.That(id, Is.EqualTo(436880871));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1910794027, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

}, null);
                Assert.That(id, Is.EqualTo(1910794027));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 1610222529, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

}, null);
                Assert.That(id, Is.EqualTo(1610222529));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 2043680545, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

});
                Assert.That(id, Is.EqualTo(2043680545));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, 577458733, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

}, null);
                Assert.That(id, Is.EqualTo(577458733));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray2mi_id
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray2mi_id", 
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

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModel(connection, 1707968857, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModel(connection, 1940055347, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

}, 1903564848);
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

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelAsync(connection, 785870921, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelAsync(connection, 1861964995, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

}, null, 468946006);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray2mi_id
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
    timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray2mi_id", 
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
                List<TimeOnlytime_without_time_zoneArray2M> models = null;
                TimeOnlytime_without_time_zoneArray2M model = null;

                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, 1188049126, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, 57733747, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

}, 1177997720).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, 475664981, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, 1508300606, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

}, null, 1636900836).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneArray2M> models = null;
                TimeOnlytime_without_time_zoneArray2M model = null;

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1032872669, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 44829295, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

}, 2032538226).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1150151335, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1718478709, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

}, 337971615).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 824751055, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1794094947, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

}, 1497209963).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1429544987, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1990028848, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

}, 106765264).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1394919596, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 615165438, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

}, 918167106).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1607543184, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 752501496, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

}, 2001866455).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1192063218, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1645200544, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

}, 436880871).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1297751641, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1733306739, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

}, null, 1910794027).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 698452295, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 2081563087, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

}, null, 1610222529).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1211912121, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 1688091256, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

}, 2043680545).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 233729705, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

}, 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, 819922039, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

}, 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

}, 577458733).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
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
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
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
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 233729705);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(27));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                await using var cmd = await ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 1150151335);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)
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
                 foreach(var batchResult in ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 233729705, 1188049126))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                        Assert.That(models, Has.Count.EqualTo(17));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                await foreach(var batchResult in ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 1607543184, 1394919596))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
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
FROM public.binary_timeonlytime_without_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
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

                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(7);

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 106765264,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 337971615,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 436880871,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 468946006,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 577458733,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 918167106,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1177997720,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106765264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

};
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
                Assert.That(model.Id, Is.EqualTo(337971615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(436880871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(468946006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

};
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
                Assert.That(model.Id, Is.EqualTo(577458733));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

};
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
                Assert.That(model.Id, Is.EqualTo(918167106));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(1177997720));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1497209963,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1610222529,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1636900836,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1903564848,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 1910794027,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 2001866455,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

}
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 2032538226,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

},
                    NullableValue = null
                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2MI
                {
                    Id = 2043680545,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(106765264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

};
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
                Assert.That(model.Id, Is.EqualTo(337971615));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(436880871));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(468946006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

};
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
                Assert.That(model.Id, Is.EqualTo(577458733));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

};
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
                Assert.That(model.Id, Is.EqualTo(918167106));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(1177997720));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(1497209963));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

};
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
                Assert.That(model.Id, Is.EqualTo(1610222529));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1636900836));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1903564848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1910794027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

};
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
                Assert.That(model.Id, Is.EqualTo(2001866455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(2032538226));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

};
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
                Assert.That(model.Id, Is.EqualTo(2043680545));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
COPY public.binary_timeonlytime_without_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
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
FROM public.binary_timeonlytime_without_time_zonearray2m m
LEFT JOIN public.binary_timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
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

                var importCollection = new List<TimeOnlytime_without_time_zoneArray2M>(15);

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 44829295,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 2032538226
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 57733747,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1177997720
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 233729705,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 475664981,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 615165438,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 918167106
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 698452295,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 752501496,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 2001866455
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 785870921,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 819922039,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 577458733
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 824751055,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1032872669,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1150151335,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1188049126,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1192063218,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1211912121,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1297751641,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1394919596,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1429544987,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1508300606,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1636900836
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1607543184,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1645200544,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 436880871
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1688091256,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 2043680545
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1707968857,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

},

                    ModelInner = null

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1718478709,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 337971615
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1733306739,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1910794027
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1794094947,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1497209963
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1861964995,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 468946006
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1940055347,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1903564848
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 1990028848,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

},
                    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

},

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 106765264
                    }

                });

                importCollection.Add(
                new TimeOnlytime_without_time_zoneArray2M
                {
                    Id = 2081563087,
                    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

},
                    NullableValue = null,

                    ModelInner = new TimeOnlytime_without_time_zoneArray2MI 
                    {
                        Id = 1610222529
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44829295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2032538226));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

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
                Assert.That(model.Id, Is.EqualTo(57733747));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1177997720));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

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
                Assert.That(model.Id, Is.EqualTo(233729705));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

};
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
                Assert.That(model.Id, Is.EqualTo(475664981));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

};
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
                Assert.That(model.Id, Is.EqualTo(615165438));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(918167106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

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
                Assert.That(model.Id, Is.EqualTo(698452295));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(752501496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2001866455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

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
                Assert.That(model.Id, Is.EqualTo(785870921));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

};
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
                Assert.That(model.Id, Is.EqualTo(819922039));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(577458733));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

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
                Assert.That(model.Id, Is.EqualTo(824751055));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

};
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
                Assert.That(model.Id, Is.EqualTo(1032872669));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

};
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
                Assert.That(model.Id, Is.EqualTo(1150151335));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1188049126));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

};
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
                Assert.That(model.Id, Is.EqualTo(1192063218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1211912121));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

};
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
                Assert.That(model.Id, Is.EqualTo(1297751641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1394919596));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1429544987));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

};
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
                Assert.That(model.Id, Is.EqualTo(1508300606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1636900836));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

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
                Assert.That(model.Id, Is.EqualTo(1607543184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1645200544));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(436880871));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

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
                Assert.That(model.Id, Is.EqualTo(1688091256));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2043680545));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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
                Assert.That(model.Id, Is.EqualTo(1707968857));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

};
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
                Assert.That(model.Id, Is.EqualTo(1718478709));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(337971615));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

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
                Assert.That(model.Id, Is.EqualTo(1733306739));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1910794027));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

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
                Assert.That(model.Id, Is.EqualTo(1794094947));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1497209963));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

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
                Assert.That(model.Id, Is.EqualTo(1861964995));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(468946006));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

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
                Assert.That(model.Id, Is.EqualTo(1940055347));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1903564848));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

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
                Assert.That(model.Id, Is.EqualTo(1990028848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(106765264));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

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
                Assert.That(model.Id, Is.EqualTo(2081563087));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1610222529));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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
COPY public.binary_timeonlytime_without_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray2M>(30);

                expected.Add(
                    44829295,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 44829295,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2032538226,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    57733747,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 57733747,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1177997720,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

}
                        }

                    }
                );

                expected.Add(
                    233729705,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 233729705,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    475664981,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 475664981,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    615165438,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 615165438,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 918167106,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

}
                        }

                    }
                );

                expected.Add(
                    698452295,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 698452295,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    752501496,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 752501496,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2001866455,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

}
                        }

                    }
                );

                expected.Add(
                    785870921,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 785870921,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    819922039,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 819922039,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 577458733,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    824751055,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 824751055,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1032872669,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1032872669,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1150151335,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1150151335,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1188049126,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1188049126,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1192063218,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1192063218,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1211912121,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1211912121,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1297751641,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1297751641,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1394919596,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1394919596,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1429544987,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1429544987,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508300606,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1508300606,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1636900836,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

}
                        }

                    }
                );

                expected.Add(
                    1607543184,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1607543184,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1645200544,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1645200544,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 436880871,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

}
                        }

                    }
                );

                expected.Add(
                    1688091256,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1688091256,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2043680545,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

}
                        }

                    }
                );

                expected.Add(
                    1707968857,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1707968857,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1718478709,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1718478709,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 337971615,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

}
                        }

                    }
                );

                expected.Add(
                    1733306739,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1733306739,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1910794027,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1794094947,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1794094947,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1497209963,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1861964995,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1861964995,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 468946006,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1940055347,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1940055347,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1903564848,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

}
                        }

                    }
                );

                expected.Add(
                    1990028848,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1990028848,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 106765264,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2081563087,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 2081563087,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1610222529,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray2M>(30);

                expected.Add(
                    44829295,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 44829295,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 25, second: 12, millisecond: 232),

new TimeOnly(hour: 13, minute: 56, second: 14, millisecond: 597),

new TimeOnly(hour: 8, minute: 57, second: 42, millisecond: 685),

new TimeOnly(hour: 10, minute: 3, second: 56, millisecond: 335),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 26, second: 53, millisecond: 833),

new TimeOnly(hour: 0, minute: 25, second: 21, millisecond: 826),

new TimeOnly(hour: 15, minute: 47, second: 33, millisecond: 133),

new TimeOnly(hour: 14, minute: 41, second: 0, millisecond: 142),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2032538226,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    57733747,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 57733747,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 39, millisecond: 604),

new TimeOnly(hour: 8, minute: 50, second: 13, millisecond: 923),

new TimeOnly(hour: 10, minute: 25, second: 33, millisecond: 132),

new TimeOnly(hour: 3, minute: 15, second: 46, millisecond: 666),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 3, millisecond: 689),

new TimeOnly(hour: 17, minute: 4, second: 20, millisecond: 641),

new TimeOnly(hour: 17, minute: 55, second: 57, millisecond: 591),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1177997720,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

}
                        }

                    }
                );

                expected.Add(
                    233729705,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 233729705,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 22, second: 18, millisecond: 412),

new TimeOnly(hour: 14, minute: 1, second: 12, millisecond: 284),

new TimeOnly(hour: 22, minute: 3, second: 20, millisecond: 758),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 732),

new TimeOnly(hour: 11, minute: 29, second: 6, millisecond: 578),

new TimeOnly(hour: 2, minute: 37, second: 6, millisecond: 543),

new TimeOnly(hour: 11, minute: 0, second: 1, millisecond: 733),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    475664981,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 475664981,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 45, millisecond: 264),

new TimeOnly(hour: 13, minute: 20, second: 27, millisecond: 944),

new TimeOnly(hour: 3, minute: 42, second: 29, millisecond: 350),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 50, second: 35, millisecond: 104),

new TimeOnly(hour: 10, minute: 54, second: 48, millisecond: 967),

new TimeOnly(hour: 8, minute: 7, second: 6, millisecond: 681),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    615165438,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 615165438,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 44, second: 10, millisecond: 604),

new TimeOnly(hour: 4, minute: 29, second: 21, millisecond: 733),

new TimeOnly(hour: 17, minute: 41, second: 25, millisecond: 469),

new TimeOnly(hour: 7, minute: 48, second: 24, millisecond: 45),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 23, millisecond: 140),

new TimeOnly(hour: 1, minute: 32, second: 53, millisecond: 784),

new TimeOnly(hour: 18, minute: 49, second: 36, millisecond: 3),

new TimeOnly(hour: 15, minute: 31, second: 38, millisecond: 330),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 918167106,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

}
                        }

                    }
                );

                expected.Add(
                    698452295,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 698452295,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 6, second: 20, millisecond: 62),

new TimeOnly(hour: 12, minute: 35, second: 10, millisecond: 102),

new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 391),

new TimeOnly(hour: 3, minute: 39, second: 8, millisecond: 602),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    752501496,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 752501496,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 3, millisecond: 183),

new TimeOnly(hour: 12, minute: 12, second: 26, millisecond: 262),

new TimeOnly(hour: 7, minute: 4, second: 17, millisecond: 339),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 7, millisecond: 574),

new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 858),

new TimeOnly(hour: 3, minute: 11, second: 40, millisecond: 486),

new TimeOnly(hour: 2, minute: 12, second: 34, millisecond: 111),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2001866455,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

}
                        }

                    }
                );

                expected.Add(
                    785870921,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 785870921,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 22, second: 18, millisecond: 669),

new TimeOnly(hour: 5, minute: 52, second: 41, millisecond: 602),

new TimeOnly(hour: 18, minute: 25, second: 52, millisecond: 200),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 53, second: 40, millisecond: 579),

new TimeOnly(hour: 18, minute: 10, second: 23, millisecond: 548),

new TimeOnly(hour: 5, minute: 51, second: 43, millisecond: 396),

new TimeOnly(hour: 9, minute: 26, second: 49, millisecond: 410),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    819922039,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 819922039,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 43, second: 36, millisecond: 80),

new TimeOnly(hour: 14, minute: 19, second: 2, millisecond: 225),

new TimeOnly(hour: 9, minute: 10, second: 24, millisecond: 605),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 58, millisecond: 535),

new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 63),

new TimeOnly(hour: 20, minute: 31, second: 0, millisecond: 663),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 577458733,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    824751055,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 824751055,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 47, second: 6, millisecond: 615),

new TimeOnly(hour: 13, minute: 46, second: 10, millisecond: 127),

new TimeOnly(hour: 11, minute: 26, second: 5, millisecond: 265),

new TimeOnly(hour: 10, minute: 17, second: 2, millisecond: 47),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 58, second: 48, millisecond: 803),

new TimeOnly(hour: 2, minute: 13, second: 56, millisecond: 245),

new TimeOnly(hour: 6, minute: 48, second: 9, millisecond: 233),

new TimeOnly(hour: 19, minute: 3, second: 46, millisecond: 312),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1032872669,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1032872669,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 1, millisecond: 32),

new TimeOnly(hour: 21, minute: 45, second: 4, millisecond: 673),

new TimeOnly(hour: 4, minute: 37, second: 13, millisecond: 659),

new TimeOnly(hour: 13, minute: 56, second: 39, millisecond: 652),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 8, second: 21, millisecond: 704),

new TimeOnly(hour: 8, minute: 10, second: 25, millisecond: 397),

new TimeOnly(hour: 20, minute: 13, second: 52, millisecond: 806),

new TimeOnly(hour: 21, minute: 6, second: 42, millisecond: 749),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1150151335,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1150151335,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 24, millisecond: 387),

new TimeOnly(hour: 14, minute: 32, second: 3, millisecond: 147),

new TimeOnly(hour: 16, minute: 20, second: 44, millisecond: 122),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1188049126,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1188049126,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 48, millisecond: 910),

new TimeOnly(hour: 11, minute: 12, second: 36, millisecond: 53),

new TimeOnly(hour: 4, minute: 29, second: 23, millisecond: 346),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 8, second: 50, millisecond: 620),

new TimeOnly(hour: 0, minute: 19, second: 54, millisecond: 45),

new TimeOnly(hour: 10, minute: 14, second: 23, millisecond: 469),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1192063218,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1192063218,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 24, millisecond: 830),

new TimeOnly(hour: 17, minute: 22, second: 55, millisecond: 593),

new TimeOnly(hour: 22, minute: 10, second: 49, millisecond: 349),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1211912121,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1211912121,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 26, second: 51, millisecond: 25),

new TimeOnly(hour: 2, minute: 45, second: 57, millisecond: 511),

new TimeOnly(hour: 20, minute: 40, second: 26, millisecond: 177),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 36, second: 13, millisecond: 815),

new TimeOnly(hour: 11, minute: 22, second: 39, millisecond: 84),

new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 252),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1297751641,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1297751641,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 16, second: 40, millisecond: 158),

new TimeOnly(hour: 16, minute: 16, second: 11, millisecond: 880),

new TimeOnly(hour: 16, minute: 49, second: 4, millisecond: 314),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1394919596,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1394919596,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 52, second: 6, millisecond: 589),

new TimeOnly(hour: 13, minute: 4, second: 5, millisecond: 296),

new TimeOnly(hour: 3, minute: 56, second: 33, millisecond: 917),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1429544987,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1429544987,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 8, second: 47, millisecond: 950),

new TimeOnly(hour: 22, minute: 27, second: 52, millisecond: 899),

new TimeOnly(hour: 20, minute: 50, second: 25, millisecond: 951),

new TimeOnly(hour: 1, minute: 34, second: 33, millisecond: 202),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 13, second: 58, millisecond: 766),

new TimeOnly(hour: 21, minute: 17, second: 11, millisecond: 780),

new TimeOnly(hour: 16, minute: 26, second: 1, millisecond: 207),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508300606,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1508300606,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 0, second: 32, millisecond: 751),

new TimeOnly(hour: 13, minute: 28, second: 31, millisecond: 990),

new TimeOnly(hour: 22, minute: 25, second: 12, millisecond: 45),

new TimeOnly(hour: 15, minute: 27, second: 54, millisecond: 550),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1636900836,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

}
                        }

                    }
                );

                expected.Add(
                    1607543184,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1607543184,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 47, second: 49, millisecond: 855),

new TimeOnly(hour: 5, minute: 58, second: 57, millisecond: 624),

new TimeOnly(hour: 1, minute: 43, second: 1, millisecond: 705),

new TimeOnly(hour: 2, minute: 36, second: 45, millisecond: 884),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1645200544,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1645200544,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 43, second: 12, millisecond: 247),

new TimeOnly(hour: 13, minute: 55, second: 4, millisecond: 454),

new TimeOnly(hour: 16, minute: 47, second: 34, millisecond: 143),

new TimeOnly(hour: 12, minute: 18, second: 30, millisecond: 997),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 7, second: 53, millisecond: 974),

new TimeOnly(hour: 15, minute: 8, second: 1, millisecond: 39),

new TimeOnly(hour: 15, minute: 47, second: 4, millisecond: 666),

new TimeOnly(hour: 15, minute: 25, second: 19, millisecond: 26),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 436880871,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

}
                        }

                    }
                );

                expected.Add(
                    1688091256,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1688091256,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 23, second: 8, millisecond: 217),

new TimeOnly(hour: 21, minute: 0, second: 14, millisecond: 832),

new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 835),

new TimeOnly(hour: 20, minute: 49, second: 57, millisecond: 128),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 48, second: 42, millisecond: 166),

new TimeOnly(hour: 18, minute: 30, second: 4, millisecond: 438),

new TimeOnly(hour: 15, minute: 4, second: 40, millisecond: 408),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 789),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 2043680545,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

}
                        }

                    }
                );

                expected.Add(
                    1707968857,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1707968857,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 21, second: 54, millisecond: 313),

new TimeOnly(hour: 11, minute: 22, second: 26, millisecond: 85),

new TimeOnly(hour: 10, minute: 21, second: 33, millisecond: 365),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 29, second: 45, millisecond: 457),

new TimeOnly(hour: 21, minute: 53, second: 30, millisecond: 581),

new TimeOnly(hour: 16, minute: 9, second: 34, millisecond: 134),

new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 6),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1718478709,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1718478709,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 22, second: 56, millisecond: 608),

new TimeOnly(hour: 4, minute: 52, second: 40, millisecond: 527),

new TimeOnly(hour: 13, minute: 49, second: 28, millisecond: 756),

new TimeOnly(hour: 13, minute: 58, second: 20, millisecond: 459),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 6, second: 37, millisecond: 423),

new TimeOnly(hour: 11, minute: 29, second: 9, millisecond: 629),

new TimeOnly(hour: 13, minute: 24, second: 18, millisecond: 157),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 337971615,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

}
                        }

                    }
                );

                expected.Add(
                    1733306739,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1733306739,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 12, second: 21, millisecond: 592),

new TimeOnly(hour: 13, minute: 47, second: 30, millisecond: 825),

new TimeOnly(hour: 9, minute: 34, second: 41, millisecond: 725),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1910794027,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1794094947,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1794094947,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 35, second: 7, millisecond: 133),

new TimeOnly(hour: 12, minute: 48, second: 56, millisecond: 11),

new TimeOnly(hour: 3, minute: 50, second: 28, millisecond: 0),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 45, second: 50, millisecond: 605),

new TimeOnly(hour: 16, minute: 7, second: 15, millisecond: 158),

new TimeOnly(hour: 22, minute: 32, second: 35, millisecond: 484),

new TimeOnly(hour: 11, minute: 44, second: 48, millisecond: 682),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1497209963,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1861964995,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1861964995,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 17, second: 47, millisecond: 267),

new TimeOnly(hour: 14, minute: 15, second: 19, millisecond: 823),

new TimeOnly(hour: 7, minute: 31, second: 37, millisecond: 64),

new TimeOnly(hour: 14, minute: 21, second: 33, millisecond: 449),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 468946006,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1940055347,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1940055347,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 87),

new TimeOnly(hour: 0, minute: 23, second: 39, millisecond: 22),

new TimeOnly(hour: 0, minute: 54, second: 16, millisecond: 726),

new TimeOnly(hour: 9, minute: 24, second: 28, millisecond: 914),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 38, millisecond: 952),

new TimeOnly(hour: 18, minute: 53, second: 41, millisecond: 684),

new TimeOnly(hour: 22, minute: 3, second: 24, millisecond: 306),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1903564848,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

},
                            NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

}
                        }

                    }
                );

                expected.Add(
                    1990028848,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 1990028848,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 19, second: 50, millisecond: 315),

new TimeOnly(hour: 1, minute: 3, second: 49, millisecond: 6),

new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 992),

new TimeOnly(hour: 0, minute: 41, second: 0, millisecond: 751),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 765),

new TimeOnly(hour: 15, minute: 28, second: 19, millisecond: 677),

new TimeOnly(hour: 7, minute: 27, second: 25, millisecond: 98),

},

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 106765264,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2081563087,
                    new TimeOnlytime_without_time_zoneArray2M
                    {
                        Id = 2081563087,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 1, second: 15, millisecond: 909),

new TimeOnly(hour: 1, minute: 1, second: 29, millisecond: 802),

new TimeOnly(hour: 19, minute: 22, second: 5, millisecond: 15),

},
                        NullableValue = null,

                        ModelInner = new TimeOnlytime_without_time_zoneArray2MI
                        {
                            Id = 1610222529,
                            Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.TimeOnly>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray2MI>(15);

                expected.Add(
                    106765264,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 106765264,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    337971615,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 337971615,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

}
                    }
                );

                expected.Add(
                    436880871,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 436880871,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

}
                    }
                );

                expected.Add(
                    468946006,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 468946006,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    577458733,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 577458733,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    918167106,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 918167106,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

}
                    }
                );

                expected.Add(
                    1177997720,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1177997720,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

}
                    }
                );

                expected.Add(
                    1497209963,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1497209963,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1610222529,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1610222529,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1636900836,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1636900836,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

}
                    }
                );

                expected.Add(
                    1903564848,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1903564848,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

}
                    }
                );

                expected.Add(
                    1910794027,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1910794027,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2001866455,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2001866455,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

}
                    }
                );

                expected.Add(
                    2032538226,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2032538226,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2043680545,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2043680545,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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

                var expected = new Dictionary<System.Int32,TimeOnlytime_without_time_zoneArray2MI>(15);

                expected.Add(
                    106765264,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 106765264,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 1, second: 19, millisecond: 549),

new TimeOnly(hour: 15, minute: 44, second: 23, millisecond: 277),

new TimeOnly(hour: 11, minute: 57, second: 48, millisecond: 683),

new TimeOnly(hour: 8, minute: 12, second: 29, millisecond: 474),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    337971615,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 337971615,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 46, millisecond: 467),

new TimeOnly(hour: 9, minute: 3, second: 52, millisecond: 508),

new TimeOnly(hour: 10, minute: 16, second: 17, millisecond: 479),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 56, second: 24, millisecond: 593),

new TimeOnly(hour: 18, minute: 56, second: 0, millisecond: 105),

new TimeOnly(hour: 22, minute: 56, second: 42, millisecond: 773),

new TimeOnly(hour: 6, minute: 37, second: 4, millisecond: 635),

}
                    }
                );

                expected.Add(
                    436880871,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 436880871,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 21, second: 38, millisecond: 403),

new TimeOnly(hour: 0, minute: 14, second: 36, millisecond: 151),

new TimeOnly(hour: 11, minute: 21, second: 19, millisecond: 561),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 13, millisecond: 927),

new TimeOnly(hour: 19, minute: 41, second: 32, millisecond: 78),

new TimeOnly(hour: 6, minute: 31, second: 12, millisecond: 459),

}
                    }
                );

                expected.Add(
                    468946006,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 468946006,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 3, second: 21, millisecond: 78),

new TimeOnly(hour: 17, minute: 0, second: 17, millisecond: 50),

new TimeOnly(hour: 10, minute: 15, second: 15, millisecond: 343),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    577458733,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 577458733,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 15, millisecond: 102),

new TimeOnly(hour: 14, minute: 52, second: 12, millisecond: 346),

new TimeOnly(hour: 9, minute: 39, second: 8, millisecond: 628),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    918167106,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 918167106,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 52, second: 51, millisecond: 499),

new TimeOnly(hour: 14, minute: 0, second: 41, millisecond: 100),

new TimeOnly(hour: 17, minute: 7, second: 0, millisecond: 61),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 905),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 19, second: 24, millisecond: 87),

new TimeOnly(hour: 19, minute: 44, second: 52, millisecond: 899),

new TimeOnly(hour: 15, minute: 51, second: 13, millisecond: 885),

}
                    }
                );

                expected.Add(
                    1177997720,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1177997720,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 32, second: 24, millisecond: 682),

new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 944),

new TimeOnly(hour: 11, minute: 19, second: 31, millisecond: 944),

new TimeOnly(hour: 19, minute: 57, second: 52, millisecond: 860),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 9, second: 1, millisecond: 479),

new TimeOnly(hour: 5, minute: 21, second: 25, millisecond: 439),

new TimeOnly(hour: 20, minute: 54, second: 56, millisecond: 280),

new TimeOnly(hour: 15, minute: 15, second: 15, millisecond: 658),

}
                    }
                );

                expected.Add(
                    1497209963,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1497209963,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 9, second: 31, millisecond: 610),

new TimeOnly(hour: 17, minute: 4, second: 14, millisecond: 19),

new TimeOnly(hour: 19, minute: 29, second: 3, millisecond: 7),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1610222529,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1610222529,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 20, second: 28, millisecond: 763),

new TimeOnly(hour: 12, minute: 24, second: 47, millisecond: 740),

new TimeOnly(hour: 6, minute: 19, second: 16, millisecond: 950),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1636900836,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1636900836,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 14, second: 38, millisecond: 760),

new TimeOnly(hour: 4, minute: 22, second: 34, millisecond: 439),

new TimeOnly(hour: 0, minute: 57, second: 25, millisecond: 256),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 123),

new TimeOnly(hour: 11, minute: 32, second: 11, millisecond: 566),

new TimeOnly(hour: 13, minute: 35, second: 10, millisecond: 638),

}
                    }
                );

                expected.Add(
                    1903564848,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1903564848,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 22, second: 0, millisecond: 552),

new TimeOnly(hour: 15, minute: 54, second: 6, millisecond: 527),

new TimeOnly(hour: 2, minute: 21, second: 51, millisecond: 256),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 17, second: 12, millisecond: 69),

new TimeOnly(hour: 22, minute: 38, second: 11, millisecond: 789),

new TimeOnly(hour: 20, minute: 36, second: 35, millisecond: 112),

}
                    }
                );

                expected.Add(
                    1910794027,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 1910794027,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 26, millisecond: 776),

new TimeOnly(hour: 9, minute: 54, second: 16, millisecond: 379),

new TimeOnly(hour: 8, minute: 51, second: 26, millisecond: 937),

new TimeOnly(hour: 6, minute: 3, second: 14, millisecond: 291),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2001866455,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2001866455,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 3, second: 20, millisecond: 406),

new TimeOnly(hour: 6, minute: 0, second: 12, millisecond: 228),

new TimeOnly(hour: 18, minute: 21, second: 34, millisecond: 306),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 19, millisecond: 169),

new TimeOnly(hour: 10, minute: 40, second: 10, millisecond: 912),

new TimeOnly(hour: 9, minute: 47, second: 37, millisecond: 760),

new TimeOnly(hour: 21, minute: 40, second: 26, millisecond: 314),

}
                    }
                );

                expected.Add(
                    2032538226,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2032538226,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 41, millisecond: 351),

new TimeOnly(hour: 0, minute: 47, second: 19, millisecond: 245),

new TimeOnly(hour: 16, minute: 8, second: 50, millisecond: 47),

new TimeOnly(hour: 11, minute: 11, second: 26, millisecond: 523),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    2043680545,
                    new TimeOnlytime_without_time_zoneArray2MI
                    {
                        Id = 2043680545,
                        Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 40, millisecond: 208),

new TimeOnly(hour: 0, minute: 19, second: 26, millisecond: 495),

new TimeOnly(hour: 9, minute: 5, second: 25, millisecond: 189),

new TimeOnly(hour: 17, minute: 16, second: 33, millisecond: 343),

},
                        NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 46, second: 23, millisecond: 64),

new TimeOnly(hour: 9, minute: 50, second: 7, millisecond: 996),

new TimeOnly(hour: 12, minute: 48, second: 17, millisecond: 631),

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

