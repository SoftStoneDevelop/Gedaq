

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
    internal partial interface INpgsqlIntervalListintervalArray
    {
    }
    
    internal partial class NpgsqlIntervalListintervalArray : INpgsqlIntervalListintervalArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2mi(
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
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
INSERT INTO public.npgsqlintervalintervalarray2mi(
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
            queryMapType: typeof(NpgsqlIntervalintervalArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
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

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, 2062859478, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, 973965140, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, 193698492, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, 1588734312, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

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

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, 2057876496, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

});
                Assert.That(id, Is.EqualTo(2057876496));

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, 1710101671, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

});
                Assert.That(id, Is.EqualTo(1710101671));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 618206173, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

});
                Assert.That(id, Is.EqualTo(618206173));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1842854850, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

});
                Assert.That(id, Is.EqualTo(1842854850));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 227242377, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

});
                Assert.That(id, Is.EqualTo(227242377));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1564683717, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

});
                Assert.That(id, Is.EqualTo(1564683717));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 587681978, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

});
                Assert.That(id, Is.EqualTo(587681978));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1471373281, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

});
                Assert.That(id, Is.EqualTo(1471373281));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1100499645, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

}, null);
                Assert.That(id, Is.EqualTo(1100499645));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1055386939, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

}, null);
                Assert.That(id, Is.EqualTo(1055386939));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, 1357733236, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

});
                Assert.That(id, Is.EqualTo(1357733236));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
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

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, 1994965081, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, 2042685418, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

}, 2062859478);
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

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, 1839507850, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, 402320434, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

}, null, 973965140);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
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
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
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
                List<NpgsqlIntervalintervalArray2M> models = null;
                NpgsqlIntervalintervalArray2M model = null;

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, 247384814, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, 1796261584, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

}, null, 193698492).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, 1474951735, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, 1969395595, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

}, 1588734312).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray2M> models = null;
                NpgsqlIntervalintervalArray2M model = null;

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 108217481, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 95873925, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

}, 2057876496).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 91630608, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1610307174, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

}, 1710101671).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1031256671, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 668956518, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

}, 618206173).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 496649573, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 375440239, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

}, 1842854850).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 2080333203, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 632281606, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

}, 227242377).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1946786756, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1555824580, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

}, 1564683717).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 333956005, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 671753700, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

}, null, 587681978).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1182873002, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1109049079, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

}, null, 1471373281).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 334311111, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 565490994, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

}, 1100499645).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 1231242387, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 825072760, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

}, null, 1055386939).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 784132771, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

}, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, 687068501, 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

}, null, 1357733236).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
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
                var models =  ((INpgsqlIntervalListintervalArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((INpgsqlIntervalListintervalArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
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
                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1031256671);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1231242387);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(10));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)
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
                 foreach(var batchResult in ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatch(connection, 565490994, 687068501))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 1994965081, 95873925))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MI),
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MI),
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

                var importCollection = new List<NpgsqlIntervalintervalArray2MI>(7);

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 193698492,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 227242377,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 587681978,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 618206173,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 973965140,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1055386939,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1100499645,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(193698492));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(227242377));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(587681978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(618206173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(973965140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(1055386939));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1100499645));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1357733236,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1471373281,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1564683717,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1588734312,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1710101671,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 1842854850,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 2057876496,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2MI
                {
                    Id = 2062859478,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(193698492));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(227242377));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(587681978));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(618206173));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(973965140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(1055386939));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1100499645));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(1357733236));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(1471373281));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1564683717));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1588734312));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1710101671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1842854850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(2057876496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(2062859478));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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
COPY public.binary_npgsqlintervalintervalarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
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
FROM public.binary_npgsqlintervalintervalarray2m m
LEFT JOIN public.binary_npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
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

                var importCollection = new List<NpgsqlIntervalintervalArray2M>(15);

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 91630608,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 95873925,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 2057876496
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 108217481,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 247384814,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 333956005,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 334311111,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 375440239,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1842854850
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 402320434,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 973965140
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 496649573,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 565490994,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1100499645
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 632281606,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 227242377
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 668956518,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 618206173
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 671753700,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 587681978
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 687068501,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1357733236
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 784132771,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 825072760,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1055386939
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1031256671,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1109049079,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1471373281
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1182873002,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1231242387,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1474951735,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1555824580,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1564683717
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1610307174,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1710101671
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1796261584,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 193698492
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1839507850,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1946786756,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1969395595,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 1588734312
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 1994965081,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 2042685418,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

},
                    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

},

                    ModelInner = new NpgsqlIntervalintervalArray2MI 
                    {
                        Id = 2062859478
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray2M
                {
                    Id = 2080333203,
                    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91630608));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

};
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
                Assert.That(model.Id, Is.EqualTo(95873925));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2057876496));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

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
                Assert.That(model.Id, Is.EqualTo(108217481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

};
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
                Assert.That(model.Id, Is.EqualTo(247384814));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(333956005));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

};
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
                Assert.That(model.Id, Is.EqualTo(334311111));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(375440239));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1842854850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

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
                Assert.That(model.Id, Is.EqualTo(402320434));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(973965140));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

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
                Assert.That(model.Id, Is.EqualTo(496649573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

};
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
                Assert.That(model.Id, Is.EqualTo(565490994));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1100499645));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

};
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
                Assert.That(model.Id, Is.EqualTo(632281606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(227242377));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

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
                Assert.That(model.Id, Is.EqualTo(668956518));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(618206173));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

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
                Assert.That(model.Id, Is.EqualTo(671753700));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(587681978));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

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
                Assert.That(model.Id, Is.EqualTo(687068501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1357733236));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

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
                Assert.That(model.Id, Is.EqualTo(784132771));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

};
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
                Assert.That(model.Id, Is.EqualTo(825072760));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055386939));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

};
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
                Assert.That(model.Id, Is.EqualTo(1031256671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

};
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
                Assert.That(model.Id, Is.EqualTo(1109049079));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1471373281));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

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
                Assert.That(model.Id, Is.EqualTo(1182873002));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

};
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
                Assert.That(model.Id, Is.EqualTo(1231242387));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

};
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
                Assert.That(model.Id, Is.EqualTo(1474951735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1555824580));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1564683717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

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
                Assert.That(model.Id, Is.EqualTo(1610307174));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710101671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

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
                Assert.That(model.Id, Is.EqualTo(1796261584));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(193698492));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

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
                Assert.That(model.Id, Is.EqualTo(1839507850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

};
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
                Assert.That(model.Id, Is.EqualTo(1946786756));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1969395595));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588734312));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

};
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
                Assert.That(model.Id, Is.EqualTo(1994965081));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2042685418));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2062859478));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

};
                    Assert.That(model.ModelInner.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080333203));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_npgsqlintervalintervalarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray2M>(30);

                expected.Add(
                    91630608,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 91630608,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    95873925,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 95873925,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 2057876496,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

}
                        }

                    }
                );

                expected.Add(
                    108217481,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 108217481,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    247384814,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 247384814,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    333956005,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 333956005,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    334311111,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 334311111,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    375440239,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 375440239,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1842854850,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

}
                        }

                    }
                );

                expected.Add(
                    402320434,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 402320434,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 973965140,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

}
                        }

                    }
                );

                expected.Add(
                    496649573,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 496649573,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    565490994,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 565490994,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1100499645,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    632281606,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 632281606,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 227242377,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

}
                        }

                    }
                );

                expected.Add(
                    668956518,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 668956518,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 618206173,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

}
                        }

                    }
                );

                expected.Add(
                    671753700,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 671753700,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 587681978,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

}
                        }

                    }
                );

                expected.Add(
                    687068501,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 687068501,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1357733236,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

}
                        }

                    }
                );

                expected.Add(
                    784132771,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 784132771,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    825072760,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 825072760,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1055386939,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1031256671,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1031256671,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1109049079,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1109049079,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1471373281,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}
                        }

                    }
                );

                expected.Add(
                    1182873002,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1182873002,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1231242387,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1231242387,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1474951735,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1474951735,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1555824580,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1555824580,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1564683717,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

}
                        }

                    }
                );

                expected.Add(
                    1610307174,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1610307174,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1710101671,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

}
                        }

                    }
                );

                expected.Add(
                    1796261584,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1796261584,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 193698492,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

}
                        }

                    }
                );

                expected.Add(
                    1839507850,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1839507850,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1946786756,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1946786756,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1969395595,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1969395595,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1588734312,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1994965081,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1994965081,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2042685418,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 2042685418,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 2062859478,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

}
                        }

                    }
                );

                expected.Add(
                    2080333203,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 2080333203,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray2M>(30);

                expected.Add(
                    91630608,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 91630608,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4077),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4475),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3600),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    95873925,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 95873925,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1881),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 487),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 2057876496,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

}
                        }

                    }
                );

                expected.Add(
                    108217481,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 108217481,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 171),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 619),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    247384814,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 247384814,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    333956005,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 333956005,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2790),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1350),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4433),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    334311111,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 334311111,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4914),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    375440239,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 375440239,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 522),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4560),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1842854850,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

}
                        }

                    }
                );

                expected.Add(
                    402320434,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 402320434,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 973965140,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

}
                        }

                    }
                );

                expected.Add(
                    496649573,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 496649573,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 214),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3637),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    565490994,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 565490994,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3532),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 915),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1100499645,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    632281606,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 632281606,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 330),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 227242377,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

}
                        }

                    }
                );

                expected.Add(
                    668956518,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 668956518,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3150),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4412),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3896),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1102),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 618206173,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

}
                        }

                    }
                );

                expected.Add(
                    671753700,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 671753700,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 175),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3341),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 587681978,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

}
                        }

                    }
                );

                expected.Add(
                    687068501,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 687068501,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1304),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1357733236,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

}
                        }

                    }
                );

                expected.Add(
                    784132771,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 784132771,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2367),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    825072760,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 825072760,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1055386939,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1031256671,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1031256671,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 840),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3826),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 535),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1109049079,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1109049079,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1471373281,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}
                        }

                    }
                );

                expected.Add(
                    1182873002,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1182873002,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4335),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1231242387,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1231242387,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2515),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4309),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1474951735,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1474951735,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1555824580,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1555824580,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3389),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2402),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1564683717,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

}
                        }

                    }
                );

                expected.Add(
                    1610307174,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1610307174,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1710101671,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

}
                        }

                    }
                );

                expected.Add(
                    1796261584,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1796261584,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4827),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 193698492,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

}
                        }

                    }
                );

                expected.Add(
                    1839507850,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1839507850,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1946786756,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1946786756,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1969395595,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1969395595,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 737),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3374),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3920),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 1588734312,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1994965081,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 1994965081,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1660),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2042685418,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 2042685418,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),

},

                        ModelInner = new NpgsqlIntervalintervalArray2MI
                        {
                            Id = 2062859478,
                            Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

},
                            NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

}
                        }

                    }
                );

                expected.Add(
                    2080333203,
                    new NpgsqlIntervalintervalArray2M
                    {
                        Id = 2080333203,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 17),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3037),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 134),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1962),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MI),
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray2MI>(15);

                expected.Add(
                    193698492,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 193698492,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

}
                    }
                );

                expected.Add(
                    227242377,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 227242377,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

}
                    }
                );

                expected.Add(
                    587681978,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 587681978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

}
                    }
                );

                expected.Add(
                    618206173,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 618206173,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

}
                    }
                );

                expected.Add(
                    973965140,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 973965140,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

}
                    }
                );

                expected.Add(
                    1055386939,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1055386939,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1100499645,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1100499645,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1357733236,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1357733236,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

}
                    }
                );

                expected.Add(
                    1471373281,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1471373281,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}
                    }
                );

                expected.Add(
                    1564683717,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1564683717,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

}
                    }
                );

                expected.Add(
                    1588734312,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1588734312,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1710101671,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1710101671,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

}
                    }
                );

                expected.Add(
                    1842854850,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1842854850,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

}
                    }
                );

                expected.Add(
                    2057876496,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 2057876496,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

}
                    }
                );

                expected.Add(
                    2062859478,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 2062859478,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray2MI>(15);

                expected.Add(
                    193698492,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 193698492,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 65),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

}
                    }
                );

                expected.Add(
                    227242377,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 227242377,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2636),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3304),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4720),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2157),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3868),

}
                    }
                );

                expected.Add(
                    587681978,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 587681978,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4148),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),

}
                    }
                );

                expected.Add(
                    618206173,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 618206173,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1248),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4284),

}
                    }
                );

                expected.Add(
                    973965140,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 973965140,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4318),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 654),

}
                    }
                );

                expected.Add(
                    1055386939,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1055386939,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4894),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4992),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2160),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1100499645,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1100499645,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 308),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1357733236,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1357733236,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1942),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2686),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),

}
                    }
                );

                expected.Add(
                    1471373281,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1471373281,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4860),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 801),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 133),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}
                    }
                );

                expected.Add(
                    1564683717,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1564683717,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 433),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4297),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),

}
                    }
                );

                expected.Add(
                    1588734312,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1588734312,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1710101671,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1710101671,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2718),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

}
                    }
                );

                expected.Add(
                    1842854850,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 1842854850,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3134),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),

}
                    }
                );

                expected.Add(
                    2057876496,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 2057876496,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4072),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),

}
                    }
                );

                expected.Add(
                    2062859478,
                    new NpgsqlIntervalintervalArray2MI
                    {
                        Id = 2062859478,
                        Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),

},
                        NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 552),

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

