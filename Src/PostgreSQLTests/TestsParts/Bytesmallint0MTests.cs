

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
    internal partial interface IByteSingleTypesmallint
    {
    }
    
    internal partial class ByteSingleTypesmallint : IByteSingleTypesmallint
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0mi(
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
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0mi(
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
            queryMapType: typeof(Bytesmallint0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
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

                changedRows =  ((IByteSingleTypesmallint)this).InsertModelInner(connection, 191036181, 105, 97);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypesmallint)this).InsertModelInner(connection, 1194938321, 142, 146);
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

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelInnerAsync(connection, 1872213724, 96, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelInnerAsync(connection, 244320881, 100, null);
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

                id =  ((IByteSingleTypesmallint)this).InsertModelInnerReturning(connection, 279054821, 39, null);
                Assert.That(id, Is.EqualTo(279054821));

                id =  ((IByteSingleTypesmallint)this).InsertModelInnerReturning(connection, 1527051625, 80, 102);
                Assert.That(id, Is.EqualTo(1527051625));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 1932620437, 112, 187);
                Assert.That(id, Is.EqualTo(1932620437));

                id = await ((IByteSingleTypesmallint)this).InsertModelInnerReturningAsync(connection, 1122256994, 220, null);
                Assert.That(id, Is.EqualTo(1122256994));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0mi(
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
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModel(connection, 1128711923, 19, null);
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

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 844666327, 130, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1018176519, 235, 139);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1982448643, 118, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 1362360440, 234, 8);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 401591138, 69, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, 764051835, 49, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
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
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallint0mi_id", 
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

                changedRows =  ((IByteSingleTypesmallint)this).InsertModel(connection, 601821999, 141, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypesmallint)this).InsertModel(connection, 1521977460, 189, null, 191036181);
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

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelAsync(connection, 1820667583, 253, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).InsertModelAsync(connection, 1725819025, 20, null, 1194938321);
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
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
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
    bytesmallint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Bytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(18)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bytesmallint0mi_id", 
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
                List<Bytesmallint0M> models = null;
                Bytesmallint0M model = null;

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, 1170666467, 28, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, 413945975, 224, null, 1872213724).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, 2079941064, 173, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IByteSingleTypesmallint)this).InsertModelReturning(connection, 187378643, 120, null, 244320881).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Bytesmallint0M> models = null;
                Bytesmallint0M model = null;

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 817242758, 99, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 450928154, 19, null, 279054821).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 1630362384, 59, 77, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IByteSingleTypesmallint)this).InsertModelReturningAsync(connection, 1987984018, 36, 112, 1527051625).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bytesmallint0m(
	id,
    value,
    nullablevalue,
    bytesmallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytesmallint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytesmallint0mi_id", 
                methodParametrName: "bytesmallint0mi_id", 
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

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertModel(connection, 347684759, 72, 26, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypesmallint)this).DbConnectionInsertModel(connection, 1530734035, 121, 96, 1932620437);
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

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 785235139, 61, 78, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1759028301, 207, null, 1122256994);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1985206841, 70, 193, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 263067403, 253, 8, 1128711923);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 135579020, 1, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 16807496, 70, 17, 844666327);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1855514739, 63, 41, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1673196685, 144, 229, 1018176519);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 976982189, 100, 208, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1883452142, 57, null, 1982448643);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 971795570, 62, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1985576105, 151, 127, 1362360440);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1856123650, 66, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 269627134, 7, 74, 401591138);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 1154831657, 135, 55, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypesmallint)this).DbConnectionInsertModelAsync(connection, 349482901, 63, 167, 764051835);
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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Bytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
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
                var models =  ((IByteSingleTypesmallint)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
                var models = await ((IByteSingleTypesmallint)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Bytesmallint0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
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
                var models =  ((IByteSingleTypesmallint)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
                var models = await ((IByteSingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
                 using var cmd =  ((IByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 269627134);
                var models =  ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
                await using var cmd = await ((IByteSingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 1883452142);
                var models = await ((IByteSingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypesmallint)
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
                 foreach(var batchResult in ((IByteSingleTypesmallint)this).DbConnectionSelectModelBatch(connection, 1154831657, 450928154))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(21));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
                await foreach(var batchResult in ((IByteSingleTypesmallint)this).DbConnectionSelectModelBatchAsync(connection, 785235139, 601821999))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

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
FROM public.bytesmallint0m m
LEFT JOIN public.bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
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
            asPartInterface: typeof(IByteSingleTypesmallint)
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
                var models =  ((IByteSingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16807496)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((844666327)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135579020)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187378643)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((120)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((244320881)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((100)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((263067403)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((253)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1128711923)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((8)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((269627134)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((401591138)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((69)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((74)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((347684759)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((72)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((349482901)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((63)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((764051835)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((49)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((167)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((413945975)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((224)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1872213724)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((450928154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((279054821)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((39)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((601821999)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((141)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((785235139)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((78)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((817242758)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((99)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((971795570)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((976982189)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((208)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154831657)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((135)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((55)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1170666467)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1521977460)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((189)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((191036181)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((105)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((97)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1530734035)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1932620437)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((112)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((187)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((96)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1630362384)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((59)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((77)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1673196685)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1018176519)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((235)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((139)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((229)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1725819025)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1194938321)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((142)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((146)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1759028301)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1122256994)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((220)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1820667583)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((253)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1855514739)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((41)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1856123650)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1883452142)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((57)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1982448643)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((118)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985206841)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((193)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985576105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((151)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1362360440)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((127)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1987984018)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((36)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1527051625)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((102)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((112)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2079941064)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((173)));//Value

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
                var models = await ((IByteSingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16807496)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((844666327)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135579020)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187378643)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((120)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((244320881)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((100)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((263067403)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((253)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1128711923)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((8)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((269627134)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((401591138)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((69)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((74)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((347684759)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((72)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((349482901)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((63)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((764051835)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((49)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((167)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((413945975)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((224)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1872213724)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((96)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((450928154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((279054821)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((39)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((601821999)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((141)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((785235139)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((61)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((78)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((817242758)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((99)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((971795570)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((976982189)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((208)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1154831657)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((135)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((55)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1170666467)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1521977460)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((189)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((191036181)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((105)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((97)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1530734035)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1932620437)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((112)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((187)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((96)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1630362384)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((59)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((77)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1673196685)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1018176519)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((235)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((139)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((229)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1725819025)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1194938321)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((142)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((146)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1759028301)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1122256994)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((220)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1820667583)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((253)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1855514739)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((63)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((41)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1856123650)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((66)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1883452142)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((57)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1982448643)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((118)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985206841)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((70)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((193)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1985576105)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((151)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1362360440)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((234)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((127)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1987984018)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((36)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1527051625)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((80)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((102)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((112)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2079941064)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((173)));//Value

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
COPY public.binary_bytesmallint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Bytesmallint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
FROM public.binary_bytesmallint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Bytesmallint0MI),
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

                var importCollection = new List<Bytesmallint0MI>(7);

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 191036181,
                    Value = 105,
                    NullableValue = 97
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 244320881,
                    Value = 100,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 279054821,
                    Value = 39,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 401591138,
                    Value = 69,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 764051835,
                    Value = 49,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 844666327,
                    Value = 130,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1018176519,
                    Value = 235,
                    NullableValue = 139
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(191036181));
                Assert.That(model.Value, Is.EqualTo(105));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(97));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244320881));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(279054821));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401591138));
                Assert.That(model.Value, Is.EqualTo(69));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(764051835));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(844666327));
                Assert.That(model.Value, Is.EqualTo(130));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1018176519));
                Assert.That(model.Value, Is.EqualTo(235));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(139));

                importCollection.Clear();

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1122256994,
                    Value = 220,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1128711923,
                    Value = 19,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1194938321,
                    Value = 142,
                    NullableValue = 146
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1362360440,
                    Value = 234,
                    NullableValue = 8
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1527051625,
                    Value = 80,
                    NullableValue = 102
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1872213724,
                    Value = 96,
                    NullableValue = null
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1932620437,
                    Value = 112,
                    NullableValue = 187
                });

                importCollection.Add(
                new Bytesmallint0MI
                {
                    Id = 1982448643,
                    Value = 118,
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(191036181));
                Assert.That(model.Value, Is.EqualTo(105));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(97));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244320881));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(279054821));
                Assert.That(model.Value, Is.EqualTo(39));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(401591138));
                Assert.That(model.Value, Is.EqualTo(69));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(764051835));
                Assert.That(model.Value, Is.EqualTo(49));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(844666327));
                Assert.That(model.Value, Is.EqualTo(130));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1018176519));
                Assert.That(model.Value, Is.EqualTo(235));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(139));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122256994));
                Assert.That(model.Value, Is.EqualTo(220));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1128711923));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1194938321));
                Assert.That(model.Value, Is.EqualTo(142));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(146));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1362360440));
                Assert.That(model.Value, Is.EqualTo(234));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1527051625));
                Assert.That(model.Value, Is.EqualTo(80));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(102));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1872213724));
                Assert.That(model.Value, Is.EqualTo(96));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1932620437));
                Assert.That(model.Value, Is.EqualTo(112));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(187));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1982448643));
                Assert.That(model.Value, Is.EqualTo(118));

                Assert.That(model.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bytesmallint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bytesmallint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Bytesmallint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
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
FROM public.binary_bytesmallint0m m
LEFT JOIN public.binary_bytesmallint0mi mi ON mi.id = m.bytesmallint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Bytesmallint0M),
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

                var importCollection = new List<Bytesmallint0M>(15);

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 16807496,
                    Value = 70,
                    NullableValue = 17,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 844666327
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 135579020,
                    Value = 1,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 187378643,
                    Value = 120,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 244320881
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 263067403,
                    Value = 253,
                    NullableValue = 8,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1128711923
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 269627134,
                    Value = 7,
                    NullableValue = 74,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 401591138
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 347684759,
                    Value = 72,
                    NullableValue = 26,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 349482901,
                    Value = 63,
                    NullableValue = 167,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 764051835
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 413945975,
                    Value = 224,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1872213724
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 450928154,
                    Value = 19,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 279054821
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 601821999,
                    Value = 141,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 785235139,
                    Value = 61,
                    NullableValue = 78,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 817242758,
                    Value = 99,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 971795570,
                    Value = 62,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 976982189,
                    Value = 100,
                    NullableValue = 208,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1154831657,
                    Value = 135,
                    NullableValue = 55,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1170666467,
                    Value = 28,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1521977460,
                    Value = 189,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 191036181
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1530734035,
                    Value = 121,
                    NullableValue = 96,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1932620437
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1630362384,
                    Value = 59,
                    NullableValue = 77,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1673196685,
                    Value = 144,
                    NullableValue = 229,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1018176519
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1725819025,
                    Value = 20,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1194938321
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1759028301,
                    Value = 207,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1122256994
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1820667583,
                    Value = 253,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1855514739,
                    Value = 63,
                    NullableValue = 41,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1856123650,
                    Value = 66,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1883452142,
                    Value = 57,
                    NullableValue = null,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1982448643
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1985206841,
                    Value = 70,
                    NullableValue = 193,

                    ModelInner = null

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1985576105,
                    Value = 151,
                    NullableValue = 127,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1362360440
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 1987984018,
                    Value = 36,
                    NullableValue = 112,

                    ModelInner = new Bytesmallint0MI 
                    {
                        Id = 1527051625
                    }

                });

                importCollection.Add(
                new Bytesmallint0M
                {
                    Id = 2079941064,
                    Value = 173,
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(16807496));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(17));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(844666327));

                Assert.That(model.ModelInner.Value, Is.EqualTo(130));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(135579020));
                Assert.That(model.Value, Is.EqualTo(1));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(187378643));
                Assert.That(model.Value, Is.EqualTo(120));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(244320881));

                Assert.That(model.ModelInner.Value, Is.EqualTo(100));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(263067403));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(8));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128711923));

                Assert.That(model.ModelInner.Value, Is.EqualTo(19));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(269627134));
                Assert.That(model.Value, Is.EqualTo(7));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(74));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(401591138));

                Assert.That(model.ModelInner.Value, Is.EqualTo(69));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(347684759));
                Assert.That(model.Value, Is.EqualTo(72));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(26));

                Assert.That(model.ModelInner, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(349482901));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(167));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(764051835));

                Assert.That(model.ModelInner.Value, Is.EqualTo(49));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(413945975));
                Assert.That(model.Value, Is.EqualTo(224));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1872213724));

                Assert.That(model.ModelInner.Value, Is.EqualTo(96));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(450928154));
                Assert.That(model.Value, Is.EqualTo(19));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(279054821));

                Assert.That(model.ModelInner.Value, Is.EqualTo(39));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(601821999));
                Assert.That(model.Value, Is.EqualTo(141));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(785235139));
                Assert.That(model.Value, Is.EqualTo(61));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(78));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(817242758));
                Assert.That(model.Value, Is.EqualTo(99));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(971795570));
                Assert.That(model.Value, Is.EqualTo(62));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(976982189));
                Assert.That(model.Value, Is.EqualTo(100));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(208));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1154831657));
                Assert.That(model.Value, Is.EqualTo(135));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(55));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1170666467));
                Assert.That(model.Value, Is.EqualTo(28));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521977460));
                Assert.That(model.Value, Is.EqualTo(189));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(191036181));

                Assert.That(model.ModelInner.Value, Is.EqualTo(105));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(97));


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1530734035));
                Assert.That(model.Value, Is.EqualTo(121));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(96));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1932620437));

                Assert.That(model.ModelInner.Value, Is.EqualTo(112));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(187));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1630362384));
                Assert.That(model.Value, Is.EqualTo(59));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(77));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1673196685));
                Assert.That(model.Value, Is.EqualTo(144));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(229));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1018176519));

                Assert.That(model.ModelInner.Value, Is.EqualTo(235));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(139));


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725819025));
                Assert.That(model.Value, Is.EqualTo(20));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1194938321));

                Assert.That(model.ModelInner.Value, Is.EqualTo(142));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(146));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1759028301));
                Assert.That(model.Value, Is.EqualTo(207));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1122256994));

                Assert.That(model.ModelInner.Value, Is.EqualTo(220));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1820667583));
                Assert.That(model.Value, Is.EqualTo(253));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1855514739));
                Assert.That(model.Value, Is.EqualTo(63));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(41));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1856123650));
                Assert.That(model.Value, Is.EqualTo(66));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1883452142));
                Assert.That(model.Value, Is.EqualTo(57));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1982448643));

                Assert.That(model.ModelInner.Value, Is.EqualTo(118));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985206841));
                Assert.That(model.Value, Is.EqualTo(70));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(193));

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1985576105));
                Assert.That(model.Value, Is.EqualTo(151));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(127));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1362360440));

                Assert.That(model.ModelInner.Value, Is.EqualTo(234));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(8));


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1987984018));
                Assert.That(model.Value, Is.EqualTo(36));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(112));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1527051625));

                Assert.That(model.ModelInner.Value, Is.EqualTo(80));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(102));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079941064));
                Assert.That(model.Value, Is.EqualTo(173));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bytesmallint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Bytesmallint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18)
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

                var expected = new Dictionary<System.Int32,Bytesmallint0M>(30);

                expected.Add(
                    16807496,
                    new Bytesmallint0M
                    {
                        Id = 16807496,
                        Value = 70,
                        NullableValue = 17,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 844666327,
                            Value = 130,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    135579020,
                    new Bytesmallint0M
                    {
                        Id = 135579020,
                        Value = 1,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    187378643,
                    new Bytesmallint0M
                    {
                        Id = 187378643,
                        Value = 120,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 244320881,
                            Value = 100,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    263067403,
                    new Bytesmallint0M
                    {
                        Id = 263067403,
                        Value = 253,
                        NullableValue = 8,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1128711923,
                            Value = 19,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    269627134,
                    new Bytesmallint0M
                    {
                        Id = 269627134,
                        Value = 7,
                        NullableValue = 74,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 401591138,
                            Value = 69,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    347684759,
                    new Bytesmallint0M
                    {
                        Id = 347684759,
                        Value = 72,
                        NullableValue = 26,

                        ModelInner = null

                    }
                );

                expected.Add(
                    349482901,
                    new Bytesmallint0M
                    {
                        Id = 349482901,
                        Value = 63,
                        NullableValue = 167,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 764051835,
                            Value = 49,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    413945975,
                    new Bytesmallint0M
                    {
                        Id = 413945975,
                        Value = 224,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1872213724,
                            Value = 96,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    450928154,
                    new Bytesmallint0M
                    {
                        Id = 450928154,
                        Value = 19,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 279054821,
                            Value = 39,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    601821999,
                    new Bytesmallint0M
                    {
                        Id = 601821999,
                        Value = 141,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    785235139,
                    new Bytesmallint0M
                    {
                        Id = 785235139,
                        Value = 61,
                        NullableValue = 78,

                        ModelInner = null

                    }
                );

                expected.Add(
                    817242758,
                    new Bytesmallint0M
                    {
                        Id = 817242758,
                        Value = 99,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    971795570,
                    new Bytesmallint0M
                    {
                        Id = 971795570,
                        Value = 62,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    976982189,
                    new Bytesmallint0M
                    {
                        Id = 976982189,
                        Value = 100,
                        NullableValue = 208,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1154831657,
                    new Bytesmallint0M
                    {
                        Id = 1154831657,
                        Value = 135,
                        NullableValue = 55,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1170666467,
                    new Bytesmallint0M
                    {
                        Id = 1170666467,
                        Value = 28,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1521977460,
                    new Bytesmallint0M
                    {
                        Id = 1521977460,
                        Value = 189,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 191036181,
                            Value = 105,
                            NullableValue = 97
                        }

                    }
                );

                expected.Add(
                    1530734035,
                    new Bytesmallint0M
                    {
                        Id = 1530734035,
                        Value = 121,
                        NullableValue = 96,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1932620437,
                            Value = 112,
                            NullableValue = 187
                        }

                    }
                );

                expected.Add(
                    1630362384,
                    new Bytesmallint0M
                    {
                        Id = 1630362384,
                        Value = 59,
                        NullableValue = 77,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1673196685,
                    new Bytesmallint0M
                    {
                        Id = 1673196685,
                        Value = 144,
                        NullableValue = 229,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1018176519,
                            Value = 235,
                            NullableValue = 139
                        }

                    }
                );

                expected.Add(
                    1725819025,
                    new Bytesmallint0M
                    {
                        Id = 1725819025,
                        Value = 20,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1194938321,
                            Value = 142,
                            NullableValue = 146
                        }

                    }
                );

                expected.Add(
                    1759028301,
                    new Bytesmallint0M
                    {
                        Id = 1759028301,
                        Value = 207,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1122256994,
                            Value = 220,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1820667583,
                    new Bytesmallint0M
                    {
                        Id = 1820667583,
                        Value = 253,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1855514739,
                    new Bytesmallint0M
                    {
                        Id = 1855514739,
                        Value = 63,
                        NullableValue = 41,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1856123650,
                    new Bytesmallint0M
                    {
                        Id = 1856123650,
                        Value = 66,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1883452142,
                    new Bytesmallint0M
                    {
                        Id = 1883452142,
                        Value = 57,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1982448643,
                            Value = 118,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1985206841,
                    new Bytesmallint0M
                    {
                        Id = 1985206841,
                        Value = 70,
                        NullableValue = 193,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1985576105,
                    new Bytesmallint0M
                    {
                        Id = 1985576105,
                        Value = 151,
                        NullableValue = 127,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1362360440,
                            Value = 234,
                            NullableValue = 8
                        }

                    }
                );

                expected.Add(
                    1987984018,
                    new Bytesmallint0M
                    {
                        Id = 1987984018,
                        Value = 36,
                        NullableValue = 112,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1527051625,
                            Value = 80,
                            NullableValue = 102
                        }

                    }
                );

                expected.Add(
                    2079941064,
                    new Bytesmallint0M
                    {
                        Id = 2079941064,
                        Value = 173,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
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

                var expected = new Dictionary<System.Int32,Bytesmallint0M>(30);

                expected.Add(
                    16807496,
                    new Bytesmallint0M
                    {
                        Id = 16807496,
                        Value = 70,
                        NullableValue = 17,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 844666327,
                            Value = 130,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    135579020,
                    new Bytesmallint0M
                    {
                        Id = 135579020,
                        Value = 1,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    187378643,
                    new Bytesmallint0M
                    {
                        Id = 187378643,
                        Value = 120,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 244320881,
                            Value = 100,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    263067403,
                    new Bytesmallint0M
                    {
                        Id = 263067403,
                        Value = 253,
                        NullableValue = 8,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1128711923,
                            Value = 19,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    269627134,
                    new Bytesmallint0M
                    {
                        Id = 269627134,
                        Value = 7,
                        NullableValue = 74,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 401591138,
                            Value = 69,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    347684759,
                    new Bytesmallint0M
                    {
                        Id = 347684759,
                        Value = 72,
                        NullableValue = 26,

                        ModelInner = null

                    }
                );

                expected.Add(
                    349482901,
                    new Bytesmallint0M
                    {
                        Id = 349482901,
                        Value = 63,
                        NullableValue = 167,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 764051835,
                            Value = 49,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    413945975,
                    new Bytesmallint0M
                    {
                        Id = 413945975,
                        Value = 224,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1872213724,
                            Value = 96,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    450928154,
                    new Bytesmallint0M
                    {
                        Id = 450928154,
                        Value = 19,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 279054821,
                            Value = 39,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    601821999,
                    new Bytesmallint0M
                    {
                        Id = 601821999,
                        Value = 141,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    785235139,
                    new Bytesmallint0M
                    {
                        Id = 785235139,
                        Value = 61,
                        NullableValue = 78,

                        ModelInner = null

                    }
                );

                expected.Add(
                    817242758,
                    new Bytesmallint0M
                    {
                        Id = 817242758,
                        Value = 99,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    971795570,
                    new Bytesmallint0M
                    {
                        Id = 971795570,
                        Value = 62,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    976982189,
                    new Bytesmallint0M
                    {
                        Id = 976982189,
                        Value = 100,
                        NullableValue = 208,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1154831657,
                    new Bytesmallint0M
                    {
                        Id = 1154831657,
                        Value = 135,
                        NullableValue = 55,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1170666467,
                    new Bytesmallint0M
                    {
                        Id = 1170666467,
                        Value = 28,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1521977460,
                    new Bytesmallint0M
                    {
                        Id = 1521977460,
                        Value = 189,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 191036181,
                            Value = 105,
                            NullableValue = 97
                        }

                    }
                );

                expected.Add(
                    1530734035,
                    new Bytesmallint0M
                    {
                        Id = 1530734035,
                        Value = 121,
                        NullableValue = 96,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1932620437,
                            Value = 112,
                            NullableValue = 187
                        }

                    }
                );

                expected.Add(
                    1630362384,
                    new Bytesmallint0M
                    {
                        Id = 1630362384,
                        Value = 59,
                        NullableValue = 77,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1673196685,
                    new Bytesmallint0M
                    {
                        Id = 1673196685,
                        Value = 144,
                        NullableValue = 229,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1018176519,
                            Value = 235,
                            NullableValue = 139
                        }

                    }
                );

                expected.Add(
                    1725819025,
                    new Bytesmallint0M
                    {
                        Id = 1725819025,
                        Value = 20,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1194938321,
                            Value = 142,
                            NullableValue = 146
                        }

                    }
                );

                expected.Add(
                    1759028301,
                    new Bytesmallint0M
                    {
                        Id = 1759028301,
                        Value = 207,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1122256994,
                            Value = 220,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1820667583,
                    new Bytesmallint0M
                    {
                        Id = 1820667583,
                        Value = 253,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1855514739,
                    new Bytesmallint0M
                    {
                        Id = 1855514739,
                        Value = 63,
                        NullableValue = 41,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1856123650,
                    new Bytesmallint0M
                    {
                        Id = 1856123650,
                        Value = 66,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1883452142,
                    new Bytesmallint0M
                    {
                        Id = 1883452142,
                        Value = 57,
                        NullableValue = null,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1982448643,
                            Value = 118,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1985206841,
                    new Bytesmallint0M
                    {
                        Id = 1985206841,
                        Value = 70,
                        NullableValue = 193,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1985576105,
                    new Bytesmallint0M
                    {
                        Id = 1985576105,
                        Value = 151,
                        NullableValue = 127,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1362360440,
                            Value = 234,
                            NullableValue = 8
                        }

                    }
                );

                expected.Add(
                    1987984018,
                    new Bytesmallint0M
                    {
                        Id = 1987984018,
                        Value = 36,
                        NullableValue = 112,

                        ModelInner = new Bytesmallint0MI
                        {
                            Id = 1527051625,
                            Value = 80,
                            NullableValue = 102
                        }

                    }
                );

                expected.Add(
                    2079941064,
                    new Bytesmallint0M
                    {
                        Id = 2079941064,
                        Value = 173,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Byte)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bytesmallint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Bytesmallint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(18),
                (NpgsqlTypes.NpgsqlDbType)(18)
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

                var expected = new Dictionary<System.Int32,Bytesmallint0MI>(15);

                expected.Add(
                    191036181,
                    new Bytesmallint0MI
                    {
                        Id = 191036181,
                        Value = 105,
                        NullableValue = 97
                    }
                );

                expected.Add(
                    244320881,
                    new Bytesmallint0MI
                    {
                        Id = 244320881,
                        Value = 100,
                        NullableValue = null
                    }
                );

                expected.Add(
                    279054821,
                    new Bytesmallint0MI
                    {
                        Id = 279054821,
                        Value = 39,
                        NullableValue = null
                    }
                );

                expected.Add(
                    401591138,
                    new Bytesmallint0MI
                    {
                        Id = 401591138,
                        Value = 69,
                        NullableValue = null
                    }
                );

                expected.Add(
                    764051835,
                    new Bytesmallint0MI
                    {
                        Id = 764051835,
                        Value = 49,
                        NullableValue = null
                    }
                );

                expected.Add(
                    844666327,
                    new Bytesmallint0MI
                    {
                        Id = 844666327,
                        Value = 130,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1018176519,
                    new Bytesmallint0MI
                    {
                        Id = 1018176519,
                        Value = 235,
                        NullableValue = 139
                    }
                );

                expected.Add(
                    1122256994,
                    new Bytesmallint0MI
                    {
                        Id = 1122256994,
                        Value = 220,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128711923,
                    new Bytesmallint0MI
                    {
                        Id = 1128711923,
                        Value = 19,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1194938321,
                    new Bytesmallint0MI
                    {
                        Id = 1194938321,
                        Value = 142,
                        NullableValue = 146
                    }
                );

                expected.Add(
                    1362360440,
                    new Bytesmallint0MI
                    {
                        Id = 1362360440,
                        Value = 234,
                        NullableValue = 8
                    }
                );

                expected.Add(
                    1527051625,
                    new Bytesmallint0MI
                    {
                        Id = 1527051625,
                        Value = 80,
                        NullableValue = 102
                    }
                );

                expected.Add(
                    1872213724,
                    new Bytesmallint0MI
                    {
                        Id = 1872213724,
                        Value = 96,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1932620437,
                    new Bytesmallint0MI
                    {
                        Id = 1932620437,
                        Value = 112,
                        NullableValue = 187
                    }
                );

                expected.Add(
                    1982448643,
                    new Bytesmallint0MI
                    {
                        Id = 1982448643,
                        Value = 118,
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

                var expected = new Dictionary<System.Int32,Bytesmallint0MI>(15);

                expected.Add(
                    191036181,
                    new Bytesmallint0MI
                    {
                        Id = 191036181,
                        Value = 105,
                        NullableValue = 97
                    }
                );

                expected.Add(
                    244320881,
                    new Bytesmallint0MI
                    {
                        Id = 244320881,
                        Value = 100,
                        NullableValue = null
                    }
                );

                expected.Add(
                    279054821,
                    new Bytesmallint0MI
                    {
                        Id = 279054821,
                        Value = 39,
                        NullableValue = null
                    }
                );

                expected.Add(
                    401591138,
                    new Bytesmallint0MI
                    {
                        Id = 401591138,
                        Value = 69,
                        NullableValue = null
                    }
                );

                expected.Add(
                    764051835,
                    new Bytesmallint0MI
                    {
                        Id = 764051835,
                        Value = 49,
                        NullableValue = null
                    }
                );

                expected.Add(
                    844666327,
                    new Bytesmallint0MI
                    {
                        Id = 844666327,
                        Value = 130,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1018176519,
                    new Bytesmallint0MI
                    {
                        Id = 1018176519,
                        Value = 235,
                        NullableValue = 139
                    }
                );

                expected.Add(
                    1122256994,
                    new Bytesmallint0MI
                    {
                        Id = 1122256994,
                        Value = 220,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128711923,
                    new Bytesmallint0MI
                    {
                        Id = 1128711923,
                        Value = 19,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1194938321,
                    new Bytesmallint0MI
                    {
                        Id = 1194938321,
                        Value = 142,
                        NullableValue = 146
                    }
                );

                expected.Add(
                    1362360440,
                    new Bytesmallint0MI
                    {
                        Id = 1362360440,
                        Value = 234,
                        NullableValue = 8
                    }
                );

                expected.Add(
                    1527051625,
                    new Bytesmallint0MI
                    {
                        Id = 1527051625,
                        Value = 80,
                        NullableValue = 102
                    }
                );

                expected.Add(
                    1872213724,
                    new Bytesmallint0MI
                    {
                        Id = 1872213724,
                        Value = 96,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1932620437,
                    new Bytesmallint0MI
                    {
                        Id = 1932620437,
                        Value = 112,
                        NullableValue = 187
                    }
                );

                expected.Add(
                    1982448643,
                    new Bytesmallint0MI
                    {
                        Id = 1982448643,
                        Value = 118,
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

