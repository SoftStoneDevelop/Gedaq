

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
    internal partial interface INpgsqlIntervalArrayintervalArray
    {
    }
    
    internal partial class NpgsqlIntervalArrayintervalArray : INpgsqlIntervalArrayintervalArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1mi(
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
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
INSERT INTO public.npgsqlintervalintervalarray1mi(
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
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
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

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInner(connection, 793430496, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInner(connection, 1845039110, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerAsync(connection, 646696869, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerAsync(connection, 5786711, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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

                id =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturning(connection, 1261824198, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

});
                Assert.That(id, Is.EqualTo(1261824198));

                id =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturning(connection, 1581177158, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

}, null);
                Assert.That(id, Is.EqualTo(1581177158));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 54909848, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

});
                Assert.That(id, Is.EqualTo(54909848));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1724424012, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

}, null);
                Assert.That(id, Is.EqualTo(1724424012));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1407970959, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

}, null);
                Assert.That(id, Is.EqualTo(1407970959));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1221640083, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

});
                Assert.That(id, Is.EqualTo(1221640083));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 978928172, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

});
                Assert.That(id, Is.EqualTo(978928172));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 654731275, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

});
                Assert.That(id, Is.EqualTo(654731275));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 714095208, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

});
                Assert.That(id, Is.EqualTo(714095208));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 1690909266, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

}, null);
                Assert.That(id, Is.EqualTo(1690909266));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, 942598921, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

}, null);
                Assert.That(id, Is.EqualTo(942598921));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray1mi_id
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray1mi_id", 
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

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModel(connection, 1497212100, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModel(connection, 1910193823, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

}, null, 793430496);
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

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelAsync(connection, 32591702, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelAsync(connection, 745101901, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

}, 1845039110);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray1mi_id
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
    npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray1mi_id", 
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
                List<NpgsqlIntervalintervalArray1M> models = null;
                NpgsqlIntervalintervalArray1M model = null;

                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, 1038512081, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, 417414320, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

}, 646696869).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, 1782978117, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, 424561485, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

}, 5786711).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray1M> models = null;
                NpgsqlIntervalintervalArray1M model = null;

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1040806112, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 607194105, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

}, null, 1261824198).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1033950830, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 593313334, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

}, 1581177158).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 665001763, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 2022363786, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

}, 54909848).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1080428609, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 765136213, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

}, 1724424012).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 2075475732, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 2080645923, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

}, 1407970959).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 2081066097, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 509514613, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

}, null, 1221640083).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1343880146, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1828103940, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

}, 978928172).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1300612172, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 284745958, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

}, 654731275).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1593684479, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 475693169, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

}, null, 714095208).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 959516475, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 275709584, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

}, 1690909266).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 1830115626, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

}, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, 120012877, 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

}, 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

}, 942598921).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
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
                var models =  ((INpgsqlIntervalArrayintervalArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
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
                var models =  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1497212100);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(9));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 2075475732);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(2));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)
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
                 foreach(var batchResult in ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 1910193823, 765136213))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 2075475732, 1782978117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
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
FROM public.binary_npgsqlintervalintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
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

                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(7);

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 5786711,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 54909848,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 646696869,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 654731275,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 714095208,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 793430496,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 942598921,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5786711));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(54909848));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(646696869));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(654731275));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(714095208));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(793430496));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(942598921));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 978928172,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1221640083,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1261824198,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

}
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1407970959,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1581177158,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1690909266,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1724424012,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

},
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1MI
                {
                    Id = 1845039110,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(5786711));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(54909848));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(646696869));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(654731275));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(714095208));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(793430496));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(942598921));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(978928172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1221640083));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(1261824198));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(1407970959));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(1581177158));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(1690909266));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(1724424012));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(1845039110));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
COPY public.binary_npgsqlintervalintervalarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
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
FROM public.binary_npgsqlintervalintervalarray1m m
LEFT JOIN public.binary_npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
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

                var importCollection = new List<NpgsqlIntervalintervalArray1M>(15);

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 32591702,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 120012877,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 942598921
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 275709584,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1690909266
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 284745958,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 654731275
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 417414320,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 646696869
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 424561485,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 5786711
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 475693169,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 714095208
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 509514613,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1221640083
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 593313334,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1581177158
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 607194105,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1261824198
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 665001763,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 745101901,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1845039110
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 765136213,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1724424012
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 959516475,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1033950830,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1038512081,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1040806112,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1080428609,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1300612172,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1343880146,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1497212100,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1593684479,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1782978117,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1828103940,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 978928172
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1830115626,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

},

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 1910193823,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

},
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 793430496
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 2022363786,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 54909848
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 2075475732,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 2080645923,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

},
                    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

},

                    ModelInner = new NpgsqlIntervalintervalArray1MI 
                    {
                        Id = 1407970959
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalintervalArray1M
                {
                    Id = 2081066097,
                    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32591702));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

};
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
                Assert.That(model.Id, Is.EqualTo(120012877));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(942598921));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

};
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
                Assert.That(model.Id, Is.EqualTo(275709584));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1690909266));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

};
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
                Assert.That(model.Id, Is.EqualTo(284745958));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(654731275));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

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
                Assert.That(model.Id, Is.EqualTo(417414320));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(646696869));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

};
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
                Assert.That(model.Id, Is.EqualTo(424561485));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(5786711));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

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
                Assert.That(model.Id, Is.EqualTo(475693169));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714095208));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

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
                Assert.That(model.Id, Is.EqualTo(509514613));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1221640083));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

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
                Assert.That(model.Id, Is.EqualTo(593313334));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1581177158));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

};
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
                Assert.That(model.Id, Is.EqualTo(607194105));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1261824198));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

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
                Assert.That(model.Id, Is.EqualTo(665001763));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

};
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
                Assert.That(model.Id, Is.EqualTo(745101901));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1845039110));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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
                Assert.That(model.Id, Is.EqualTo(765136213));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

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

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1724424012));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

};
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
                Assert.That(model.Id, Is.EqualTo(959516475));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

};
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
                Assert.That(model.Id, Is.EqualTo(1033950830));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1038512081));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1040806112));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1080428609));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

};
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
                Assert.That(model.Id, Is.EqualTo(1300612172));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

};
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
                Assert.That(model.Id, Is.EqualTo(1343880146));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1497212100));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1593684479));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1782978117));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

};
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
                Assert.That(model.Id, Is.EqualTo(1828103940));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(978928172));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

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
                Assert.That(model.Id, Is.EqualTo(1830115626));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

};
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
                Assert.That(model.Id, Is.EqualTo(1910193823));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(793430496));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

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
                Assert.That(model.Id, Is.EqualTo(2022363786));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(54909848));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

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
                Assert.That(model.Id, Is.EqualTo(2075475732));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2080645923));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1407970959));

                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

};
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
                Assert.That(model.Id, Is.EqualTo(2081066097));
                {
                    var expectEnumerValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_npgsqlintervalintervalarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray1M>(30);

                expected.Add(
                    32591702,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 32591702,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    120012877,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 120012877,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 942598921,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    275709584,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 275709584,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1690909266,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    284745958,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 284745958,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 654731275,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

}
                        }

                    }
                );

                expected.Add(
                    417414320,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 417414320,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 646696869,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    424561485,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 424561485,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 5786711,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

}
                        }

                    }
                );

                expected.Add(
                    475693169,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 475693169,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 714095208,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

}
                        }

                    }
                );

                expected.Add(
                    509514613,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 509514613,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1221640083,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

}
                        }

                    }
                );

                expected.Add(
                    593313334,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 593313334,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1581177158,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    607194105,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 607194105,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1261824198,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

}
                        }

                    }
                );

                expected.Add(
                    665001763,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 665001763,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    745101901,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 745101901,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1845039110,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

}
                        }

                    }
                );

                expected.Add(
                    765136213,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 765136213,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1724424012,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    959516475,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 959516475,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1033950830,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1033950830,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1038512081,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1038512081,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1040806112,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1040806112,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1080428609,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1080428609,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1300612172,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1300612172,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1343880146,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1343880146,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1497212100,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1497212100,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1593684479,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1593684479,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1782978117,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1782978117,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1828103940,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1828103940,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 978928172,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

}
                        }

                    }
                );

                expected.Add(
                    1830115626,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1830115626,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910193823,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1910193823,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 793430496,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

}
                        }

                    }
                );

                expected.Add(
                    2022363786,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2022363786,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 54909848,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

}
                        }

                    }
                );

                expected.Add(
                    2075475732,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2075475732,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2080645923,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2080645923,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1407970959,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2081066097,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2081066097,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray1M>(30);

                expected.Add(
                    32591702,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 32591702,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    120012877,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 120012877,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 9),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2734),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 912),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 942598921,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    275709584,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 275709584,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 114),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1690909266,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    284745958,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 284745958,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1911),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3883),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 654731275,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

}
                        }

                    }
                );

                expected.Add(
                    417414320,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 417414320,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1930),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1346),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4182),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4542),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 646696869,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    424561485,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 424561485,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3025),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 5786711,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

}
                        }

                    }
                );

                expected.Add(
                    475693169,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 475693169,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4229),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 706),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3251),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 714095208,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

}
                        }

                    }
                );

                expected.Add(
                    509514613,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 509514613,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2394),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4629),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1221640083,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

}
                        }

                    }
                );

                expected.Add(
                    593313334,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 593313334,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 523),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1892),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1581177158,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    607194105,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 607194105,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 147),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1261824198,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

}
                        }

                    }
                );

                expected.Add(
                    665001763,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 665001763,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    745101901,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 745101901,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2857),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4076),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1940),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 60),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1845039110,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

}
                        }

                    }
                );

                expected.Add(
                    765136213,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 765136213,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1721),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1865),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1724424012,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    959516475,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 959516475,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2577),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 74),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1033950830,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1033950830,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1038512081,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1038512081,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2034),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1040806112,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1040806112,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4780),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1080428609,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1080428609,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1798),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3212),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2572),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2066),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3165),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1300612172,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1300612172,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1297),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1926),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4041),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1343880146,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1343880146,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1497212100,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1497212100,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1593684479,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1593684479,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1941),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3035),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1782978117,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1782978117,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2602),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1413),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1828103940,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1828103940,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 77),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 957),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 978928172,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

}
                        }

                    }
                );

                expected.Add(
                    1830115626,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1830115626,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910193823,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 1910193823,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),

},
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 793430496,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

}
                        }

                    }
                );

                expected.Add(
                    2022363786,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2022363786,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3687),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 30),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3136),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 54909848,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

},
                            NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

}
                        }

                    }
                );

                expected.Add(
                    2075475732,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2075475732,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2275),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2080645923,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2080645923,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 67),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4251),

},

                        ModelInner = new NpgsqlIntervalintervalArray1MI
                        {
                            Id = 1407970959,
                            Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2081066097,
                    new NpgsqlIntervalintervalArray1M
                    {
                        Id = 2081066097,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4846),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray1MI>(15);

                expected.Add(
                    5786711,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 5786711,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

}
                    }
                );

                expected.Add(
                    54909848,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 54909848,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

}
                    }
                );

                expected.Add(
                    646696869,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 646696869,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    654731275,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 654731275,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

}
                    }
                );

                expected.Add(
                    714095208,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 714095208,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

}
                    }
                );

                expected.Add(
                    793430496,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 793430496,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

}
                    }
                );

                expected.Add(
                    942598921,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 942598921,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    978928172,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 978928172,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

}
                    }
                );

                expected.Add(
                    1221640083,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1221640083,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

}
                    }
                );

                expected.Add(
                    1261824198,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1261824198,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

}
                    }
                );

                expected.Add(
                    1407970959,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1407970959,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1581177158,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1581177158,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1690909266,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1690909266,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1724424012,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1724424012,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1845039110,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1845039110,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalintervalArray1MI>(15);

                expected.Add(
                    5786711,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 5786711,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),

}
                    }
                );

                expected.Add(
                    54909848,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 54909848,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4342),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3434),

}
                    }
                );

                expected.Add(
                    646696869,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 646696869,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3858),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    654731275,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 654731275,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1487),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

}
                    }
                );

                expected.Add(
                    714095208,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 714095208,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 201),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1533),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

}
                    }
                );

                expected.Add(
                    793430496,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 793430496,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4090),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 639),

}
                    }
                );

                expected.Add(
                    942598921,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 942598921,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4146),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1869),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    978928172,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 978928172,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1856),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 820),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2580),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

}
                    }
                );

                expected.Add(
                    1221640083,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1221640083,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 71),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2105),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),

}
                    }
                );

                expected.Add(
                    1261824198,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1261824198,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1747),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 714),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4802),

}
                    }
                );

                expected.Add(
                    1407970959,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1407970959,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4945),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4002),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1581177158,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1581177158,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4258),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1690909266,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1690909266,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1421),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1724424012,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1724424012,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1845039110,
                    new NpgsqlIntervalintervalArray1MI
                    {
                        Id = 1845039110,
                        Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4563),

},
                        NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4959),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

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

