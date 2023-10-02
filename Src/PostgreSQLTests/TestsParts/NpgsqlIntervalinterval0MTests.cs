

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
    internal partial interface INpgsqlIntervalSingleTypeinterval
    {
    }
    
    internal partial class NpgsqlIntervalSingleTypeinterval : INpgsqlIntervalSingleTypeinterval
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0mi(
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0mi(
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
            queryMapType: typeof(NpgsqlIntervalinterval0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInner(connection, 1134596991, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInner(connection, 1042108553, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807));
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerAsync(connection, 1057858746, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerAsync(connection, 1057573597, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678), null);
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

                id =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturning(connection, 1587697273, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464), null);
                Assert.That(id, Is.EqualTo(1587697273));

                id =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturning(connection, 1618632633, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324), null);
                Assert.That(id, Is.EqualTo(1618632633));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, 273069317, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494));
                Assert.That(id, Is.EqualTo(273069317));

                id = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelInnerReturningAsync(connection, 710929300, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782), null);
                Assert.That(id, Is.EqualTo(710929300));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0mi(
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModel(connection, 1305250854, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220));
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 792908492, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1102996607, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1998150782, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 433875098, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1704308600, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertInnerModelAsync(connection, 1454444265, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
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
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModel(connection, 1057552853, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModel(connection, 153062599, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584), null, 1134596991);
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelAsync(connection, 1143713517, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelAsync(connection, 1225291109, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930), null, 1042108553);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
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
    npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(30)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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
                List<NpgsqlIntervalinterval0M> models = null;
                NpgsqlIntervalinterval0M model = null;

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, 1616630434, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, 1566819463, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879), 1057858746).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, 402395559, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturning(connection, 555551623, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068), null, 1057573597).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalinterval0M> models = null;
                NpgsqlIntervalinterval0M model = null;

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, 806387487, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, 2022097088, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326), 1587697273).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, 1849768597, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((INpgsqlIntervalSingleTypeinterval)this).InsertModelReturningAsync(connection, 1550727226, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738), null, 1618632633).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalinterval0m(
	id,
    value,
    nullablevalue,
    npgsqlintervalinterval0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlintervalinterval0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlInterval), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlintervalinterval0mi_id", 
                methodParametrName: "npgsqlintervalinterval0mi_id", 
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

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModel(connection, 1106951365, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModel(connection, 323021129, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863), null, 273069317);
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

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1322388404, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1428048541, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213), 710929300);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 996677594, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 252655570, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805), null, 1305250854);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 402097362, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 104242639, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747), 792908492);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 296571266, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 867195676, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708), 1102996607);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1822661189, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 1972528874, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860), null, 1998150782);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 758121454, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 755393789, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763), 433875098);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 427964398, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 110937936, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762), new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658), 1704308600);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 714621412, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionInsertModelAsync(connection, 154784885, new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225), null, 1454444265);
                Assert.That(changedRows, Is.EqualTo(1));

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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
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
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

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
FROM public.npgsqlintervalinterval0m m
LEFT JOIN public.npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
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
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalSingleTypeinterval)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 154784885);
                var models =  ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlIntervalSingleTypeinterval)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalSingleTypeinterval)this).SetDbConnectionSelectModelParametrs(cmd, 323021129);
                var models = await ((INpgsqlIntervalSingleTypeinterval)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalSingleTypeinterval)
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
                 foreach(var batchResult in ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelBatch(connection, 1106951365, 104242639))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(29));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[26];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                        model = models[28];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

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
                await foreach(var batchResult in ((INpgsqlIntervalSingleTypeinterval)this).DbConnectionSelectModelBatchAsync(connection, 1550727226, 555551623))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

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
COPY public.binary_npgsqlintervalinterval0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalinterval0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
FROM public.binary_npgsqlintervalinterval0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(NpgsqlIntervalinterval0MI),
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

                var importCollection = new List<NpgsqlIntervalinterval0MI>(7);

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 273069317,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 433875098,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 710929300,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 792908492,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1042108553,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1057573597,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1057858746,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273069317));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(433875098));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(710929300));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792908492));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1042108553));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057573597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057858746));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1102996607,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1134596991,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1305250854,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1454444265,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1587697273,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1618632633,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324),
                    NullableValue = null
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1704308600,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)
                });

                importCollection.Add(
                new NpgsqlIntervalinterval0MI
                {
                    Id = 1998150782,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(273069317));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(433875098));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(710929300));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(792908492));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1042108553));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057573597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057858746));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1102996607));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1134596991));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1305250854));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1454444265));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1587697273));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1618632633));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1704308600));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1998150782));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalinterval0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
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
FROM public.binary_npgsqlintervalinterval0m m
LEFT JOIN public.binary_npgsqlintervalinterval0mi mi ON mi.id = m.npgsqlintervalinterval0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
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

                var importCollection = new List<NpgsqlIntervalinterval0M>(15);

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 104242639,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 792908492
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 110937936,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1704308600
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 153062599,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1134596991
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 154784885,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1454444265
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 252655570,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1305250854
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 296571266,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 323021129,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 273069317
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 402097362,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 402395559,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 427964398,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 555551623,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1057573597
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 714621412,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 755393789,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 433875098
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 758121454,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 806387487,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335),
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 867195676,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1102996607
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 996677594,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1057552853,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1106951365,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1143713517,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1225291109,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1042108553
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1322388404,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1428048541,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 710929300
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1550727226,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1618632633
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1566819463,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1057858746
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1616630434,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528),

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1822661189,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1849768597,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 1972528874,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860),
                    NullableValue = null,

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1998150782
                    }

                });

                importCollection.Add(
                new NpgsqlIntervalinterval0M
                {
                    Id = 2022097088,
                    Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677),
                    NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326),

                    ModelInner = new NpgsqlIntervalinterval0MI 
                    {
                        Id = 1587697273
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104242639));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(792908492));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(110937936));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1704308600));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(153062599));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1134596991));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(154784885));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1454444265));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(252655570));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1305250854));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296571266));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(323021129));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(273069317));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402097362));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(402395559));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(427964398));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(555551623));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057573597));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(714621412));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(755393789));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(433875098));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(758121454));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(806387487));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(867195676));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1102996607));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(996677594));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1057552853));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1106951365));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1143713517));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225291109));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1042108553));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1322388404));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1428048541));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(710929300));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1550727226));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1618632633));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1566819463));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1057858746));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)));


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1616630434));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1822661189));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1849768597));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1972528874));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1998150782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2022097088));
                Assert.That(model.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1587697273));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalinterval0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalinterval0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(NpgsqlIntervalinterval0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30)
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalinterval0M>(30);

                expected.Add(
                    104242639,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 104242639,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 792908492,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    110937936,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 110937936,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1704308600,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)
                        }

                    }
                );

                expected.Add(
                    153062599,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 153062599,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1134596991,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)
                        }

                    }
                );

                expected.Add(
                    154784885,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 154784885,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1454444265,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)
                        }

                    }
                );

                expected.Add(
                    252655570,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 252655570,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1305250854,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)
                        }

                    }
                );

                expected.Add(
                    296571266,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 296571266,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    323021129,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 323021129,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 273069317,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)
                        }

                    }
                );

                expected.Add(
                    402097362,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 402097362,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

                        ModelInner = null

                    }
                );

                expected.Add(
                    402395559,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 402395559,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021),

                        ModelInner = null

                    }
                );

                expected.Add(
                    427964398,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 427964398,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

                        ModelInner = null

                    }
                );

                expected.Add(
                    555551623,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 555551623,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1057573597,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    714621412,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 714621412,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    755393789,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 755393789,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 433875098,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)
                        }

                    }
                );

                expected.Add(
                    758121454,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 758121454,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735),

                        ModelInner = null

                    }
                );

                expected.Add(
                    806387487,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 806387487,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    867195676,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 867195676,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1102996607,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    996677594,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 996677594,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1057552853,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1057552853,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1106951365,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1106951365,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1143713517,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1143713517,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1225291109,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1225291109,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1042108553,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)
                        }

                    }
                );

                expected.Add(
                    1322388404,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1322388404,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1428048541,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1428048541,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 710929300,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1550727226,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1550727226,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1618632633,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1566819463,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1566819463,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1057858746,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)
                        }

                    }
                );

                expected.Add(
                    1616630434,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1616630434,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1822661189,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1822661189,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1849768597,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1849768597,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972528874,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1972528874,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1998150782,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)
                        }

                    }
                );

                expected.Add(
                    2022097088,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 2022097088,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1587697273,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalinterval0M>(30);

                expected.Add(
                    104242639,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 104242639,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3089),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 747),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 792908492,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    110937936,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 110937936,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2658),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1704308600,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)
                        }

                    }
                );

                expected.Add(
                    153062599,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 153062599,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3584),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1134596991,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)
                        }

                    }
                );

                expected.Add(
                    154784885,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 154784885,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4225),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1454444265,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)
                        }

                    }
                );

                expected.Add(
                    252655570,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 252655570,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1305250854,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)
                        }

                    }
                );

                expected.Add(
                    296571266,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 296571266,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    323021129,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 323021129,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 273069317,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)
                        }

                    }
                );

                expected.Add(
                    402097362,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 402097362,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4391),

                        ModelInner = null

                    }
                );

                expected.Add(
                    402395559,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 402395559,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4822),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021),

                        ModelInner = null

                    }
                );

                expected.Add(
                    427964398,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 427964398,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3895),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 56),

                        ModelInner = null

                    }
                );

                expected.Add(
                    555551623,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 555551623,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3068),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1057573597,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    714621412,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 714621412,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    755393789,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 755393789,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 916),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 433875098,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)
                        }

                    }
                );

                expected.Add(
                    758121454,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 758121454,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 120),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735),

                        ModelInner = null

                    }
                );

                expected.Add(
                    806387487,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 806387487,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    867195676,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 867195676,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2945),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 708),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1102996607,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    996677594,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 996677594,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 764),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1057552853,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1057552853,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2292),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1106951365,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1106951365,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3844),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1161),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1143713517,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1143713517,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1225291109,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1225291109,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2930),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1042108553,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)
                        }

                    }
                );

                expected.Add(
                    1322388404,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1322388404,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4699),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1428048541,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1428048541,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4786),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 710929300,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1550727226,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1550727226,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3738),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1618632633,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1566819463,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1566819463,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 289),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1879),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1057858746,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)
                        }

                    }
                );

                expected.Add(
                    1616630434,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1616630434,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2638),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1528),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1822661189,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1822661189,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4128),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1849768597,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1849768597,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2723),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1972528874,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 1972528874,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860),
                        NullableValue = null,

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1998150782,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067),
                            NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)
                        }

                    }
                );

                expected.Add(
                    2022097088,
                    new NpgsqlIntervalinterval0M
                    {
                        Id = 2022097088,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 326),

                        ModelInner = new NpgsqlIntervalinterval0MI
                        {
                            Id = 1587697273,
                            Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue == null)
                {
                    Assert.That(model.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
                }

                if(expectedModel.ModelInner == null)
                {
                    Assert.That(model.ModelInner, Is.Null);
                }
                else
                {
                    Assert.That(model.ModelInner, Is.Not.Null);
                    Assert.That(model.ModelInner.Id, Is.EqualTo(expectedModel.ModelInner.Id));

                    Assert.That(model.ModelInner.Value, Is.EqualTo((NpgsqlTypes.NpgsqlInterval)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalinterval0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(NpgsqlIntervalinterval0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(30),
                (NpgsqlTypes.NpgsqlDbType)(30)
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalinterval0MI>(15);

                expected.Add(
                    273069317,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 273069317,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)
                    }
                );

                expected.Add(
                    433875098,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 433875098,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)
                    }
                );

                expected.Add(
                    710929300,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 710929300,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
                        NullableValue = null
                    }
                );

                expected.Add(
                    792908492,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 792908492,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1042108553,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1042108553,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)
                    }
                );

                expected.Add(
                    1057573597,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1057573597,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1057858746,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1057858746,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)
                    }
                );

                expected.Add(
                    1102996607,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1102996607,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1134596991,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1134596991,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)
                    }
                );

                expected.Add(
                    1305250854,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1305250854,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)
                    }
                );

                expected.Add(
                    1454444265,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1454444265,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)
                    }
                );

                expected.Add(
                    1587697273,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1587697273,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1618632633,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1618632633,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1704308600,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1704308600,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)
                    }
                );

                expected.Add(
                    1998150782,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1998150782,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
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

                var expected = new Dictionary<System.Int32,NpgsqlIntervalinterval0MI>(15);

                expected.Add(
                    273069317,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 273069317,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 837),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2494)
                    }
                );

                expected.Add(
                    433875098,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 433875098,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3589),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418)
                    }
                );

                expected.Add(
                    710929300,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 710929300,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
                        NullableValue = null
                    }
                );

                expected.Add(
                    792908492,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 792908492,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1712),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1042108553,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1042108553,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807)
                    }
                );

                expected.Add(
                    1057573597,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1057573597,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1057858746,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1057858746,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401)
                    }
                );

                expected.Add(
                    1102996607,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1102996607,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1134596991,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1134596991,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2788),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4115)
                    }
                );

                expected.Add(
                    1305250854,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1305250854,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220)
                    }
                );

                expected.Add(
                    1454444265,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1454444265,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888)
                    }
                );

                expected.Add(
                    1587697273,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1587697273,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1618632633,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1618632633,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 324),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1704308600,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1704308600,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2256)
                    }
                );

                expected.Add(
                    1998150782,
                    new NpgsqlIntervalinterval0MI
                    {
                        Id = 1998150782,
                        Value = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2067),
                        NullableValue = new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3004)
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
                Assert.That(model.Value, Is.EqualTo(expectedModel.Value));
                if(expectedModel.NullableValue != null)
                {
                    Assert.That(model.NullableValue, Is.Not.Null);
                    Assert.That(model.NullableValue, Is.EqualTo(expectedModel.NullableValue));
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

