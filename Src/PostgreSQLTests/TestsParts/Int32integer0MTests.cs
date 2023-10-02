

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
    internal partial interface IInt32SingleTypeinteger
    {
    }
    
    internal partial class Int32SingleTypeinteger : IInt32SingleTypeinteger
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            queryMapType: typeof(Int32integer0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
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

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, 139842910, 1718315159, 705118159);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, 79914408, 1860521553, null);
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

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, 129335670, 696999204, 751435837);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, 1301880540, 1674328707, 1913193876);
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

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, 66747153, 742711572, null);
                Assert.That(id, Is.EqualTo(66747153));

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, 1589346887, 1255327110, 1418886249);
                Assert.That(id, Is.EqualTo(1589346887));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, 1737495427, 994021424, 1142730297);
                Assert.That(id, Is.EqualTo(1737495427));

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, 1121738114, 1655758500, null);
                Assert.That(id, Is.EqualTo(1121738114));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModel(connection, 2074514303, 1823839550, 2009872192);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 1856125943, 1399106090, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 1922262281, 506408035, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 1784107527, 847284136, 1104370583);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 1768983431, 1145191367, 1742863557);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 216914404, 75596538, 1716785179);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, 228346851, 1420377772, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, 382137516, 1187436156, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, 1536552319, 704112976, null, 139842910);
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

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, 163147178, 491901967, 442974156, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, 862752688, 1229029547, 1456691783, 79914408);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32? nullable = null;

                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, 1683076725, 770290493, 1362799017, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1362799017));

                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, 1355961354, 1495812448, null, 129335670);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32? nullable = null;

                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, 248637995, 1460604126, 793167254, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(793167254));

                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, 979315193, 1552962027, 145885996, 1301880540);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(145885996));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
    int32integer0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Int32integer0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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
                List<Int32integer0M> models = null;
                Int32integer0M model = null;

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, 1497699765, 243819411, 942228276, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, 212773122, 1152131129, 1544373135, 66747153).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, 838633919, 158053824, 790071933, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, 104190749, 1212146954, null, 1589346887).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integer0M> models = null;
                Int32integer0M model = null;

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, 1593194872, 190378662, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, 55641689, 422820067, null, 1737495427).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, 122054979, 886807130, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, 1112930892, 1225601954, null, 1121738114).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32integer0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32integer0mi_id", 
                methodParametrName: "int32integer0mi_id", 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, 510866813, 1110443291, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, 849440024, 1740290310, 1211755820, 2074514303);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 406055102, 2054237872, 1004202972, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 1910392246, 1795686527, null, 1856125943);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 178952841, 1802589107, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 158720396, 1663682206, null, 1922262281);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 259030675, 1192217681, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 216958357, 1009715799, 1966673043, 1784107527);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 2012294566, 431676932, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 613023474, 932360115, null, 1768983431);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 1717933965, 1368059517, 2011301752, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 1614944628, 1321088525, null, 216914404);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 1489974071, 400907178, 696808120, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, 1671481590, 1785621969, null, 228346851);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int32integer0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
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
                var models =  ((IInt32SingleTypeinteger)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                var models = await ((IInt32SingleTypeinteger)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int32integer0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
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
                var models =  ((IInt32SingleTypeinteger)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                var models = await ((IInt32SingleTypeinteger)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                 using var cmd =  ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 849440024);
                var models =  ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(14));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                await using var cmd = await ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 510866813);
                var models = await ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
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
                 foreach(var batchResult in ((IInt32SingleTypeinteger)this).DbConnectionSelectModelBatch(connection, 1536552319, 216958357))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                await foreach(var batchResult in ((IInt32SingleTypeinteger)this).DbConnectionSelectModelBatchAsync(connection, 613023474, 1536552319))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

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
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger)
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
                var models =  ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55641689)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((422820067)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1737495427)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((994021424)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1142730297)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104190749)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1212146954)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1589346887)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1255327110)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1418886249)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122054979)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((886807130)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158720396)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1663682206)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1922262281)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((506408035)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163147178)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((491901967)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((442974156)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178952841)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1802589107)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((212773122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1152131129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66747153)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((742711572)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1544373135)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((216958357)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1009715799)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1784107527)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((847284136)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1104370583)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1966673043)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((248637995)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1460604126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((793167254)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259030675)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1192217681)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382137516)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1187436156)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((406055102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2054237872)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1004202972)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((510866813)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1110443291)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((613023474)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((932360115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1768983431)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1145191367)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1742863557)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((838633919)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((158053824)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((790071933)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((849440024)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1740290310)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2074514303)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1823839550)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2009872192)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1211755820)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((862752688)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1229029547)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79914408)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1860521553)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1456691783)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((979315193)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1552962027)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1301880540)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1674328707)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1913193876)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((145885996)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1112930892)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1225601954)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1121738114)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1655758500)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1355961354)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1495812448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((129335670)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((696999204)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((751435837)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1489974071)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((400907178)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((696808120)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1497699765)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((243819411)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((942228276)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1536552319)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((704112976)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((139842910)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1718315159)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((705118159)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1593194872)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((190378662)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1614944628)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1321088525)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((216914404)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((75596538)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1716785179)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1671481590)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1785621969)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((228346851)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1420377772)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1683076725)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((770290493)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1362799017)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1717933965)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1368059517)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2011301752)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910392246)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1795686527)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1856125943)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1399106090)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2012294566)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((431676932)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55641689)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((422820067)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1737495427)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((994021424)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1142730297)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104190749)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1212146954)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1589346887)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1255327110)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1418886249)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122054979)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((886807130)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158720396)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1663682206)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1922262281)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((506408035)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163147178)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((491901967)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((442974156)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178952841)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1802589107)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((212773122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1152131129)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66747153)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((742711572)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1544373135)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((216958357)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1009715799)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1784107527)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((847284136)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1104370583)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1966673043)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((248637995)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1460604126)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((793167254)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259030675)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1192217681)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((382137516)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1187436156)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((406055102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2054237872)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1004202972)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((510866813)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1110443291)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((613023474)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((932360115)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1768983431)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1145191367)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1742863557)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((838633919)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((158053824)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((790071933)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((849440024)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1740290310)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2074514303)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1823839550)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2009872192)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1211755820)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((862752688)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1229029547)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79914408)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1860521553)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1456691783)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((979315193)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1552962027)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1301880540)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1674328707)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1913193876)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((145885996)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1112930892)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1225601954)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1121738114)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1655758500)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1355961354)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1495812448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((129335670)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((696999204)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((751435837)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1489974071)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((400907178)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((696808120)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1497699765)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((243819411)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((942228276)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1536552319)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((704112976)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((139842910)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1718315159)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((705118159)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1593194872)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((190378662)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1614944628)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1321088525)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((216914404)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((75596538)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1716785179)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1671481590)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1785621969)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((228346851)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1420377772)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1683076725)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((770290493)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1362799017)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1717933965)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1368059517)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2011301752)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910392246)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1795686527)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1856125943)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1399106090)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2012294566)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((431676932)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integer0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Int32integer0MI),
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

                var importCollection = new List<Int32integer0MI>(7);

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 66747153,
                    Value = 742711572,
                    NullableValue = null
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 79914408,
                    Value = 1860521553,
                    NullableValue = null
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 129335670,
                    Value = 696999204,
                    NullableValue = 751435837
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 139842910,
                    Value = 1718315159,
                    NullableValue = 705118159
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 216914404,
                    Value = 75596538,
                    NullableValue = 1716785179
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 228346851,
                    Value = 1420377772,
                    NullableValue = null
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1121738114,
                    Value = 1655758500,
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66747153));
                Assert.That(model.Value, Is.EqualTo(742711572));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(79914408));
                Assert.That(model.Value, Is.EqualTo(1860521553));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(129335670));
                Assert.That(model.Value, Is.EqualTo(696999204));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(751435837));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139842910));
                Assert.That(model.Value, Is.EqualTo(1718315159));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(705118159));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216914404));
                Assert.That(model.Value, Is.EqualTo(75596538));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1716785179));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228346851));
                Assert.That(model.Value, Is.EqualTo(1420377772));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1121738114));
                Assert.That(model.Value, Is.EqualTo(1655758500));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1301880540,
                    Value = 1674328707,
                    NullableValue = 1913193876
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1589346887,
                    Value = 1255327110,
                    NullableValue = 1418886249
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1737495427,
                    Value = 994021424,
                    NullableValue = 1142730297
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1768983431,
                    Value = 1145191367,
                    NullableValue = 1742863557
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1784107527,
                    Value = 847284136,
                    NullableValue = 1104370583
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1856125943,
                    Value = 1399106090,
                    NullableValue = null
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 1922262281,
                    Value = 506408035,
                    NullableValue = null
                });

                importCollection.Add(
                new Int32integer0MI
                {
                    Id = 2074514303,
                    Value = 1823839550,
                    NullableValue = 2009872192
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66747153));
                Assert.That(model.Value, Is.EqualTo(742711572));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(79914408));
                Assert.That(model.Value, Is.EqualTo(1860521553));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(129335670));
                Assert.That(model.Value, Is.EqualTo(696999204));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(751435837));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139842910));
                Assert.That(model.Value, Is.EqualTo(1718315159));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(705118159));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216914404));
                Assert.That(model.Value, Is.EqualTo(75596538));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1716785179));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(228346851));
                Assert.That(model.Value, Is.EqualTo(1420377772));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1121738114));
                Assert.That(model.Value, Is.EqualTo(1655758500));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1301880540));
                Assert.That(model.Value, Is.EqualTo(1674328707));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1913193876));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1589346887));
                Assert.That(model.Value, Is.EqualTo(1255327110));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1418886249));


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1737495427));
                Assert.That(model.Value, Is.EqualTo(994021424));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1142730297));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1768983431));
                Assert.That(model.Value, Is.EqualTo(1145191367));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1742863557));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1784107527));
                Assert.That(model.Value, Is.EqualTo(847284136));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1104370583));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856125943));
                Assert.That(model.Value, Is.EqualTo(1399106090));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1922262281));
                Assert.That(model.Value, Is.EqualTo(506408035));

                Assert.That(model.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074514303));
                Assert.That(model.Value, Is.EqualTo(1823839550));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2009872192));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integer0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integer0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
FROM public.binary_int32integer0m m
LEFT JOIN public.binary_int32integer0mi mi ON mi.id = m.int32integer0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Int32integer0M),
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

                var importCollection = new List<Int32integer0M>(15);

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 55641689,
                    Value = 422820067,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1737495427
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 104190749,
                    Value = 1212146954,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1589346887
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 122054979,
                    Value = 886807130,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 158720396,
                    Value = 1663682206,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1922262281
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 163147178,
                    Value = 491901967,
                    NullableValue = 442974156,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 178952841,
                    Value = 1802589107,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 212773122,
                    Value = 1152131129,
                    NullableValue = 1544373135,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 66747153
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 216958357,
                    Value = 1009715799,
                    NullableValue = 1966673043,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1784107527
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 248637995,
                    Value = 1460604126,
                    NullableValue = 793167254,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 259030675,
                    Value = 1192217681,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 382137516,
                    Value = 1187436156,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 406055102,
                    Value = 2054237872,
                    NullableValue = 1004202972,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 510866813,
                    Value = 1110443291,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 613023474,
                    Value = 932360115,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1768983431
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 838633919,
                    Value = 158053824,
                    NullableValue = 790071933,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 849440024,
                    Value = 1740290310,
                    NullableValue = 1211755820,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 2074514303
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 862752688,
                    Value = 1229029547,
                    NullableValue = 1456691783,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 79914408
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 979315193,
                    Value = 1552962027,
                    NullableValue = 145885996,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1301880540
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1112930892,
                    Value = 1225601954,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1121738114
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1355961354,
                    Value = 1495812448,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 129335670
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1489974071,
                    Value = 400907178,
                    NullableValue = 696808120,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1497699765,
                    Value = 243819411,
                    NullableValue = 942228276,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1536552319,
                    Value = 704112976,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 139842910
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1593194872,
                    Value = 190378662,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1614944628,
                    Value = 1321088525,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 216914404
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1671481590,
                    Value = 1785621969,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 228346851
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1683076725,
                    Value = 770290493,
                    NullableValue = 1362799017,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1717933965,
                    Value = 1368059517,
                    NullableValue = 2011301752,

                    ModelInner = null

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 1910392246,
                    Value = 1795686527,
                    NullableValue = null,

                    ModelInner = new Int32integer0MI 
                    {
                        Id = 1856125943
                    }

                });

                importCollection.Add(
                new Int32integer0M
                {
                    Id = 2012294566,
                    Value = 431676932,
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(55641689));
                Assert.That(model.Value, Is.EqualTo(422820067));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1737495427));

                Assert.That(model.ModelInner.Value, Is.EqualTo(994021424));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1142730297));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(104190749));
                Assert.That(model.Value, Is.EqualTo(1212146954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1589346887));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1255327110));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1418886249));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(122054979));
                Assert.That(model.Value, Is.EqualTo(886807130));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(158720396));
                Assert.That(model.Value, Is.EqualTo(1663682206));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1922262281));

                Assert.That(model.ModelInner.Value, Is.EqualTo(506408035));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(163147178));
                Assert.That(model.Value, Is.EqualTo(491901967));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(442974156));

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178952841));
                Assert.That(model.Value, Is.EqualTo(1802589107));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(212773122));
                Assert.That(model.Value, Is.EqualTo(1152131129));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1544373135));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(66747153));

                Assert.That(model.ModelInner.Value, Is.EqualTo(742711572));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(216958357));
                Assert.That(model.Value, Is.EqualTo(1009715799));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1966673043));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1784107527));

                Assert.That(model.ModelInner.Value, Is.EqualTo(847284136));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1104370583));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(248637995));
                Assert.That(model.Value, Is.EqualTo(1460604126));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(793167254));

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259030675));
                Assert.That(model.Value, Is.EqualTo(1192217681));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(382137516));
                Assert.That(model.Value, Is.EqualTo(1187436156));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(406055102));
                Assert.That(model.Value, Is.EqualTo(2054237872));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1004202972));

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(510866813));
                Assert.That(model.Value, Is.EqualTo(1110443291));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(613023474));
                Assert.That(model.Value, Is.EqualTo(932360115));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1768983431));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1145191367));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1742863557));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(838633919));
                Assert.That(model.Value, Is.EqualTo(158053824));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(790071933));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(849440024));
                Assert.That(model.Value, Is.EqualTo(1740290310));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1211755820));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2074514303));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1823839550));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(2009872192));


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(862752688));
                Assert.That(model.Value, Is.EqualTo(1229029547));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1456691783));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(79914408));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1860521553));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979315193));
                Assert.That(model.Value, Is.EqualTo(1552962027));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(145885996));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1301880540));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1674328707));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1913193876));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1112930892));
                Assert.That(model.Value, Is.EqualTo(1225601954));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1121738114));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1655758500));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1355961354));
                Assert.That(model.Value, Is.EqualTo(1495812448));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(129335670));

                Assert.That(model.ModelInner.Value, Is.EqualTo(696999204));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(751435837));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1489974071));
                Assert.That(model.Value, Is.EqualTo(400907178));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(696808120));

                Assert.That(model.ModelInner, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1497699765));
                Assert.That(model.Value, Is.EqualTo(243819411));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(942228276));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1536552319));
                Assert.That(model.Value, Is.EqualTo(704112976));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(139842910));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1718315159));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(705118159));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1593194872));
                Assert.That(model.Value, Is.EqualTo(190378662));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1614944628));
                Assert.That(model.Value, Is.EqualTo(1321088525));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(216914404));

                Assert.That(model.ModelInner.Value, Is.EqualTo(75596538));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(1716785179));


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1671481590));
                Assert.That(model.Value, Is.EqualTo(1785621969));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(228346851));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1420377772));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683076725));
                Assert.That(model.Value, Is.EqualTo(770290493));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(1362799017));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717933965));
                Assert.That(model.Value, Is.EqualTo(1368059517));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(2011301752));

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910392246));
                Assert.That(model.Value, Is.EqualTo(1795686527));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1856125943));

                Assert.That(model.ModelInner.Value, Is.EqualTo(1399106090));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2012294566));
                Assert.That(model.Value, Is.EqualTo(431676932));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integer0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Int32integer0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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

                var expected = new Dictionary<System.Int32,Int32integer0M>(30);

                expected.Add(
                    55641689,
                    new Int32integer0M
                    {
                        Id = 55641689,
                        Value = 422820067,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1737495427,
                            Value = 994021424,
                            NullableValue = 1142730297
                        }

                    }
                );

                expected.Add(
                    104190749,
                    new Int32integer0M
                    {
                        Id = 104190749,
                        Value = 1212146954,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1589346887,
                            Value = 1255327110,
                            NullableValue = 1418886249
                        }

                    }
                );

                expected.Add(
                    122054979,
                    new Int32integer0M
                    {
                        Id = 122054979,
                        Value = 886807130,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    158720396,
                    new Int32integer0M
                    {
                        Id = 158720396,
                        Value = 1663682206,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1922262281,
                            Value = 506408035,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    163147178,
                    new Int32integer0M
                    {
                        Id = 163147178,
                        Value = 491901967,
                        NullableValue = 442974156,

                        ModelInner = null

                    }
                );

                expected.Add(
                    178952841,
                    new Int32integer0M
                    {
                        Id = 178952841,
                        Value = 1802589107,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    212773122,
                    new Int32integer0M
                    {
                        Id = 212773122,
                        Value = 1152131129,
                        NullableValue = 1544373135,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 66747153,
                            Value = 742711572,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    216958357,
                    new Int32integer0M
                    {
                        Id = 216958357,
                        Value = 1009715799,
                        NullableValue = 1966673043,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1784107527,
                            Value = 847284136,
                            NullableValue = 1104370583
                        }

                    }
                );

                expected.Add(
                    248637995,
                    new Int32integer0M
                    {
                        Id = 248637995,
                        Value = 1460604126,
                        NullableValue = 793167254,

                        ModelInner = null

                    }
                );

                expected.Add(
                    259030675,
                    new Int32integer0M
                    {
                        Id = 259030675,
                        Value = 1192217681,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    382137516,
                    new Int32integer0M
                    {
                        Id = 382137516,
                        Value = 1187436156,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    406055102,
                    new Int32integer0M
                    {
                        Id = 406055102,
                        Value = 2054237872,
                        NullableValue = 1004202972,

                        ModelInner = null

                    }
                );

                expected.Add(
                    510866813,
                    new Int32integer0M
                    {
                        Id = 510866813,
                        Value = 1110443291,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    613023474,
                    new Int32integer0M
                    {
                        Id = 613023474,
                        Value = 932360115,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1768983431,
                            Value = 1145191367,
                            NullableValue = 1742863557
                        }

                    }
                );

                expected.Add(
                    838633919,
                    new Int32integer0M
                    {
                        Id = 838633919,
                        Value = 158053824,
                        NullableValue = 790071933,

                        ModelInner = null

                    }
                );

                expected.Add(
                    849440024,
                    new Int32integer0M
                    {
                        Id = 849440024,
                        Value = 1740290310,
                        NullableValue = 1211755820,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 2074514303,
                            Value = 1823839550,
                            NullableValue = 2009872192
                        }

                    }
                );

                expected.Add(
                    862752688,
                    new Int32integer0M
                    {
                        Id = 862752688,
                        Value = 1229029547,
                        NullableValue = 1456691783,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 79914408,
                            Value = 1860521553,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    979315193,
                    new Int32integer0M
                    {
                        Id = 979315193,
                        Value = 1552962027,
                        NullableValue = 145885996,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1301880540,
                            Value = 1674328707,
                            NullableValue = 1913193876
                        }

                    }
                );

                expected.Add(
                    1112930892,
                    new Int32integer0M
                    {
                        Id = 1112930892,
                        Value = 1225601954,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1121738114,
                            Value = 1655758500,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1355961354,
                    new Int32integer0M
                    {
                        Id = 1355961354,
                        Value = 1495812448,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 129335670,
                            Value = 696999204,
                            NullableValue = 751435837
                        }

                    }
                );

                expected.Add(
                    1489974071,
                    new Int32integer0M
                    {
                        Id = 1489974071,
                        Value = 400907178,
                        NullableValue = 696808120,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1497699765,
                    new Int32integer0M
                    {
                        Id = 1497699765,
                        Value = 243819411,
                        NullableValue = 942228276,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1536552319,
                    new Int32integer0M
                    {
                        Id = 1536552319,
                        Value = 704112976,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 139842910,
                            Value = 1718315159,
                            NullableValue = 705118159
                        }

                    }
                );

                expected.Add(
                    1593194872,
                    new Int32integer0M
                    {
                        Id = 1593194872,
                        Value = 190378662,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1614944628,
                    new Int32integer0M
                    {
                        Id = 1614944628,
                        Value = 1321088525,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 216914404,
                            Value = 75596538,
                            NullableValue = 1716785179
                        }

                    }
                );

                expected.Add(
                    1671481590,
                    new Int32integer0M
                    {
                        Id = 1671481590,
                        Value = 1785621969,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 228346851,
                            Value = 1420377772,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1683076725,
                    new Int32integer0M
                    {
                        Id = 1683076725,
                        Value = 770290493,
                        NullableValue = 1362799017,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1717933965,
                    new Int32integer0M
                    {
                        Id = 1717933965,
                        Value = 1368059517,
                        NullableValue = 2011301752,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910392246,
                    new Int32integer0M
                    {
                        Id = 1910392246,
                        Value = 1795686527,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1856125943,
                            Value = 1399106090,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2012294566,
                    new Int32integer0M
                    {
                        Id = 2012294566,
                        Value = 431676932,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
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

                var expected = new Dictionary<System.Int32,Int32integer0M>(30);

                expected.Add(
                    55641689,
                    new Int32integer0M
                    {
                        Id = 55641689,
                        Value = 422820067,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1737495427,
                            Value = 994021424,
                            NullableValue = 1142730297
                        }

                    }
                );

                expected.Add(
                    104190749,
                    new Int32integer0M
                    {
                        Id = 104190749,
                        Value = 1212146954,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1589346887,
                            Value = 1255327110,
                            NullableValue = 1418886249
                        }

                    }
                );

                expected.Add(
                    122054979,
                    new Int32integer0M
                    {
                        Id = 122054979,
                        Value = 886807130,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    158720396,
                    new Int32integer0M
                    {
                        Id = 158720396,
                        Value = 1663682206,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1922262281,
                            Value = 506408035,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    163147178,
                    new Int32integer0M
                    {
                        Id = 163147178,
                        Value = 491901967,
                        NullableValue = 442974156,

                        ModelInner = null

                    }
                );

                expected.Add(
                    178952841,
                    new Int32integer0M
                    {
                        Id = 178952841,
                        Value = 1802589107,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    212773122,
                    new Int32integer0M
                    {
                        Id = 212773122,
                        Value = 1152131129,
                        NullableValue = 1544373135,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 66747153,
                            Value = 742711572,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    216958357,
                    new Int32integer0M
                    {
                        Id = 216958357,
                        Value = 1009715799,
                        NullableValue = 1966673043,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1784107527,
                            Value = 847284136,
                            NullableValue = 1104370583
                        }

                    }
                );

                expected.Add(
                    248637995,
                    new Int32integer0M
                    {
                        Id = 248637995,
                        Value = 1460604126,
                        NullableValue = 793167254,

                        ModelInner = null

                    }
                );

                expected.Add(
                    259030675,
                    new Int32integer0M
                    {
                        Id = 259030675,
                        Value = 1192217681,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    382137516,
                    new Int32integer0M
                    {
                        Id = 382137516,
                        Value = 1187436156,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    406055102,
                    new Int32integer0M
                    {
                        Id = 406055102,
                        Value = 2054237872,
                        NullableValue = 1004202972,

                        ModelInner = null

                    }
                );

                expected.Add(
                    510866813,
                    new Int32integer0M
                    {
                        Id = 510866813,
                        Value = 1110443291,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    613023474,
                    new Int32integer0M
                    {
                        Id = 613023474,
                        Value = 932360115,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1768983431,
                            Value = 1145191367,
                            NullableValue = 1742863557
                        }

                    }
                );

                expected.Add(
                    838633919,
                    new Int32integer0M
                    {
                        Id = 838633919,
                        Value = 158053824,
                        NullableValue = 790071933,

                        ModelInner = null

                    }
                );

                expected.Add(
                    849440024,
                    new Int32integer0M
                    {
                        Id = 849440024,
                        Value = 1740290310,
                        NullableValue = 1211755820,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 2074514303,
                            Value = 1823839550,
                            NullableValue = 2009872192
                        }

                    }
                );

                expected.Add(
                    862752688,
                    new Int32integer0M
                    {
                        Id = 862752688,
                        Value = 1229029547,
                        NullableValue = 1456691783,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 79914408,
                            Value = 1860521553,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    979315193,
                    new Int32integer0M
                    {
                        Id = 979315193,
                        Value = 1552962027,
                        NullableValue = 145885996,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1301880540,
                            Value = 1674328707,
                            NullableValue = 1913193876
                        }

                    }
                );

                expected.Add(
                    1112930892,
                    new Int32integer0M
                    {
                        Id = 1112930892,
                        Value = 1225601954,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1121738114,
                            Value = 1655758500,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1355961354,
                    new Int32integer0M
                    {
                        Id = 1355961354,
                        Value = 1495812448,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 129335670,
                            Value = 696999204,
                            NullableValue = 751435837
                        }

                    }
                );

                expected.Add(
                    1489974071,
                    new Int32integer0M
                    {
                        Id = 1489974071,
                        Value = 400907178,
                        NullableValue = 696808120,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1497699765,
                    new Int32integer0M
                    {
                        Id = 1497699765,
                        Value = 243819411,
                        NullableValue = 942228276,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1536552319,
                    new Int32integer0M
                    {
                        Id = 1536552319,
                        Value = 704112976,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 139842910,
                            Value = 1718315159,
                            NullableValue = 705118159
                        }

                    }
                );

                expected.Add(
                    1593194872,
                    new Int32integer0M
                    {
                        Id = 1593194872,
                        Value = 190378662,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1614944628,
                    new Int32integer0M
                    {
                        Id = 1614944628,
                        Value = 1321088525,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 216914404,
                            Value = 75596538,
                            NullableValue = 1716785179
                        }

                    }
                );

                expected.Add(
                    1671481590,
                    new Int32integer0M
                    {
                        Id = 1671481590,
                        Value = 1785621969,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 228346851,
                            Value = 1420377772,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1683076725,
                    new Int32integer0M
                    {
                        Id = 1683076725,
                        Value = 770290493,
                        NullableValue = 1362799017,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1717933965,
                    new Int32integer0M
                    {
                        Id = 1717933965,
                        Value = 1368059517,
                        NullableValue = 2011301752,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1910392246,
                    new Int32integer0M
                    {
                        Id = 1910392246,
                        Value = 1795686527,
                        NullableValue = null,

                        ModelInner = new Int32integer0MI
                        {
                            Id = 1856125943,
                            Value = 1399106090,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2012294566,
                    new Int32integer0M
                    {
                        Id = 2012294566,
                        Value = 431676932,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int32)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Int32integer0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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

                var expected = new Dictionary<System.Int32,Int32integer0MI>(15);

                expected.Add(
                    66747153,
                    new Int32integer0MI
                    {
                        Id = 66747153,
                        Value = 742711572,
                        NullableValue = null
                    }
                );

                expected.Add(
                    79914408,
                    new Int32integer0MI
                    {
                        Id = 79914408,
                        Value = 1860521553,
                        NullableValue = null
                    }
                );

                expected.Add(
                    129335670,
                    new Int32integer0MI
                    {
                        Id = 129335670,
                        Value = 696999204,
                        NullableValue = 751435837
                    }
                );

                expected.Add(
                    139842910,
                    new Int32integer0MI
                    {
                        Id = 139842910,
                        Value = 1718315159,
                        NullableValue = 705118159
                    }
                );

                expected.Add(
                    216914404,
                    new Int32integer0MI
                    {
                        Id = 216914404,
                        Value = 75596538,
                        NullableValue = 1716785179
                    }
                );

                expected.Add(
                    228346851,
                    new Int32integer0MI
                    {
                        Id = 228346851,
                        Value = 1420377772,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1121738114,
                    new Int32integer0MI
                    {
                        Id = 1121738114,
                        Value = 1655758500,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1301880540,
                    new Int32integer0MI
                    {
                        Id = 1301880540,
                        Value = 1674328707,
                        NullableValue = 1913193876
                    }
                );

                expected.Add(
                    1589346887,
                    new Int32integer0MI
                    {
                        Id = 1589346887,
                        Value = 1255327110,
                        NullableValue = 1418886249
                    }
                );

                expected.Add(
                    1737495427,
                    new Int32integer0MI
                    {
                        Id = 1737495427,
                        Value = 994021424,
                        NullableValue = 1142730297
                    }
                );

                expected.Add(
                    1768983431,
                    new Int32integer0MI
                    {
                        Id = 1768983431,
                        Value = 1145191367,
                        NullableValue = 1742863557
                    }
                );

                expected.Add(
                    1784107527,
                    new Int32integer0MI
                    {
                        Id = 1784107527,
                        Value = 847284136,
                        NullableValue = 1104370583
                    }
                );

                expected.Add(
                    1856125943,
                    new Int32integer0MI
                    {
                        Id = 1856125943,
                        Value = 1399106090,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1922262281,
                    new Int32integer0MI
                    {
                        Id = 1922262281,
                        Value = 506408035,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2074514303,
                    new Int32integer0MI
                    {
                        Id = 2074514303,
                        Value = 1823839550,
                        NullableValue = 2009872192
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

                var expected = new Dictionary<System.Int32,Int32integer0MI>(15);

                expected.Add(
                    66747153,
                    new Int32integer0MI
                    {
                        Id = 66747153,
                        Value = 742711572,
                        NullableValue = null
                    }
                );

                expected.Add(
                    79914408,
                    new Int32integer0MI
                    {
                        Id = 79914408,
                        Value = 1860521553,
                        NullableValue = null
                    }
                );

                expected.Add(
                    129335670,
                    new Int32integer0MI
                    {
                        Id = 129335670,
                        Value = 696999204,
                        NullableValue = 751435837
                    }
                );

                expected.Add(
                    139842910,
                    new Int32integer0MI
                    {
                        Id = 139842910,
                        Value = 1718315159,
                        NullableValue = 705118159
                    }
                );

                expected.Add(
                    216914404,
                    new Int32integer0MI
                    {
                        Id = 216914404,
                        Value = 75596538,
                        NullableValue = 1716785179
                    }
                );

                expected.Add(
                    228346851,
                    new Int32integer0MI
                    {
                        Id = 228346851,
                        Value = 1420377772,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1121738114,
                    new Int32integer0MI
                    {
                        Id = 1121738114,
                        Value = 1655758500,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1301880540,
                    new Int32integer0MI
                    {
                        Id = 1301880540,
                        Value = 1674328707,
                        NullableValue = 1913193876
                    }
                );

                expected.Add(
                    1589346887,
                    new Int32integer0MI
                    {
                        Id = 1589346887,
                        Value = 1255327110,
                        NullableValue = 1418886249
                    }
                );

                expected.Add(
                    1737495427,
                    new Int32integer0MI
                    {
                        Id = 1737495427,
                        Value = 994021424,
                        NullableValue = 1142730297
                    }
                );

                expected.Add(
                    1768983431,
                    new Int32integer0MI
                    {
                        Id = 1768983431,
                        Value = 1145191367,
                        NullableValue = 1742863557
                    }
                );

                expected.Add(
                    1784107527,
                    new Int32integer0MI
                    {
                        Id = 1784107527,
                        Value = 847284136,
                        NullableValue = 1104370583
                    }
                );

                expected.Add(
                    1856125943,
                    new Int32integer0MI
                    {
                        Id = 1856125943,
                        Value = 1399106090,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1922262281,
                    new Int32integer0MI
                    {
                        Id = 1922262281,
                        Value = 506408035,
                        NullableValue = null
                    }
                );

                expected.Add(
                    2074514303,
                    new Int32integer0MI
                    {
                        Id = 2074514303,
                        Value = 1823839550,
                        NullableValue = 2009872192
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

