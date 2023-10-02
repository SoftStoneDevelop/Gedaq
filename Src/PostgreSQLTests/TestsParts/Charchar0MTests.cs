

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
    internal partial interface ICharSingleTypechar
    {
    }
    
    internal partial class CharSingleTypechar : ICharSingleTypechar
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchar0mi(
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
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchar0mi(
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
            queryMapType: typeof(Charchar0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
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

                changedRows =  ((ICharSingleTypechar)this).InsertModelInner(connection, 538208494, 'g', 'c');
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ICharSingleTypechar)this).InsertModelInner(connection, 1351455098, 'r', null);
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

                changedRows = await ((ICharSingleTypechar)this).InsertModelInnerAsync(connection, 1162616732, 'y', 'y');
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).InsertModelInnerAsync(connection, 1640961624, 'n', 'q');
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

                id =  ((ICharSingleTypechar)this).InsertModelInnerReturning(connection, 1729812315, 's', 'c');
                Assert.That(id, Is.EqualTo(1729812315));

                id =  ((ICharSingleTypechar)this).InsertModelInnerReturning(connection, 137233138, 'e', null);
                Assert.That(id, Is.EqualTo(137233138));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((ICharSingleTypechar)this).InsertModelInnerReturningAsync(connection, 543249275, 'y', 'k');
                Assert.That(id, Is.EqualTo(543249275));

                id = await ((ICharSingleTypechar)this).InsertModelInnerReturningAsync(connection, 1023072520, 'm', 'c');
                Assert.That(id, Is.EqualTo(1023072520));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.charchar0mi(
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
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Char), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(16)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16), 
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

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertInnerModel(connection, 1105663317, 'm', null);
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

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 1713213418, 'e', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 1185182541, 'g', 'h');
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 1717784456, 'm', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 1940932433, 'd', 'o');
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 142926684, 'e', 'f');
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, 1728892275, 'w', null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchar0m(
	id,
    value,
    nullablevalue,
    charchar0mi_id
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
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "charchar0mi_id", 
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

                changedRows =  ((ICharSingleTypechar)this).InsertModel(connection, 259778914, 'e', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ICharSingleTypechar)this).InsertModel(connection, 1433659558, 'w', 'p', 538208494);
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

                changedRows = await ((ICharSingleTypechar)this).InsertModelAsync(connection, 1837542961, 'x', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).InsertModelAsync(connection, 491884600, 'x', null, 1351455098);
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
INSERT INTO public.charchar0m(
	id,
    value,
    nullablevalue,
    charchar0mi_id
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
    charchar0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Charchar0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "charchar0mi_id", 
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
                List<Charchar0M> models = null;
                Charchar0M model = null;

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, 1122628690, 'y', 'w', null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, 10754171, 'n', 'x', 1162616732).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Char)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, 443238142, 'b', null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, 1459101644, 't', 'g', 1640961624).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Char)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Charchar0M> models = null;
                Charchar0M model = null;

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, 984889099, 'x', 'm', null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, 1591194653, 'r', 'u', 1729812315).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Char)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, 1365497029, 'r', 'm', null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, 140622805, 'p', null, 137233138).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Char)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.charchar0m(
	id,
    value,
    nullablevalue,
    charchar0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @charchar0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Char), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "charchar0mi_id", 
                methodParametrName: "charchar0mi_id", 
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

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertModel(connection, 1276212086, 'x', 'm', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertModel(connection, 1210710966, 's', null, 543249275);
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

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 1004094797, 'x', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 340094217, 'f', 'n', 1023072520);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 502615459, 'r', 'h', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 311189983, 'g', 'i', 1105663317);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 1225189137, 'w', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 858081174, 'e', 'v', 1713213418);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 907332181, 'e', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 495970124, 'r', 'r', 1185182541);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 1910475342, 'k', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 546456252, 's', null, 1717784456);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 299143368, 'i', null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 218772351, 'v', null, 1940932433);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 2094011702, 'e', 'r', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 796856689, 'j', 'u', 142926684);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 1113401491, 'd', 'x', null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, 1069443446, 'q', 'c', 1728892275);
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
FROM public.charchar0m m
LEFT JOIN public.charchar0mi mi ON mi.id = m.charchar0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Charchar0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
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
                var models =  ((ICharSingleTypechar)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

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
FROM public.charchar0m m
LEFT JOIN public.charchar0mi mi ON mi.id = m.charchar0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Charchar0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
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
                var models =  ((ICharSingleTypechar)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ICharSingleTypechar)this).CreateDbConnectionSelectModelCommand(connection);
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 495970124);
                var models =  ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(20));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ICharSingleTypechar)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 1113401491);
                var models = await ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(11));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)
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
                 foreach(var batchResult in ((ICharSingleTypechar)this).DbConnectionSelectModelBatch(connection, 311189983, 858081174))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

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
                await foreach(var batchResult in ((ICharSingleTypechar)this).DbConnectionSelectModelBatchAsync(connection, 1365497029, 1225189137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

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
FROM public.charchar0m m
LEFT JOIN public.charchar0mi mi ON mi.id = m.charchar0mi_id
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
            asPartInterface: typeof(ICharSingleTypechar)
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
                var models =  ((ICharSingleTypechar)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10754171)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1162616732)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140622805)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((137233138)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((218772351)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('v').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1940932433)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('d').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259778914)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((299143368)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('i').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((311189983)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1105663317)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('i').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((340094217)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1023072520)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((443238142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((491884600)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1351455098)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((495970124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1185182541)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502615459)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('h').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((546456252)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1717784456)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((796856689)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('j').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((142926684)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('f').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((858081174)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1713213418)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('v').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((907332181)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((984889099)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1004094797)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1069443446)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1728892275)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1113401491)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1122628690)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('w').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1210710966)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((543249275)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1225189137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1276212086)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1365497029)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1433659558)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((538208494)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('p').ToString()));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1459101644)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1640961624)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('n').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('q').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1591194653)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1729812315)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('s').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1837542961)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910475342)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2094011702)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10754171)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1162616732)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140622805)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((137233138)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((218772351)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('v').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1940932433)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('d').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((259778914)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((299143368)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('i').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((311189983)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1105663317)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('i').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((340094217)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1023072520)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((443238142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((491884600)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1351455098)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((495970124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1185182541)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((502615459)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('h').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((546456252)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1717784456)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((796856689)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('j').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((142926684)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('f').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((858081174)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1713213418)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('v').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((907332181)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((984889099)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1004094797)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1069443446)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1728892275)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1113401491)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1122628690)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('w').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1210710966)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((543249275)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1225189137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1276212086)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1365497029)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1433659558)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((538208494)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('p').ToString()));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1459101644)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1640961624)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('n').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('q').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1591194653)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1729812315)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('s').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('c').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1837542961)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1910475342)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2094011702)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_charchar0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Charchar0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
FROM public.binary_charchar0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Charchar0MI),
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

                var importCollection = new List<Charchar0MI>(7);

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 137233138,
                    Value = 'e',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 142926684,
                    Value = 'e',
                    NullableValue = 'f'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 538208494,
                    Value = 'g',
                    NullableValue = 'c'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 543249275,
                    Value = 'y',
                    NullableValue = 'k'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1023072520,
                    Value = 'm',
                    NullableValue = 'c'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1105663317,
                    Value = 'm',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1162616732,
                    Value = 'y',
                    NullableValue = 'y'
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(137233138));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142926684));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('f'));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(538208494));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543249275));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('k'));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023072520));
                Assert.That(model.Value, Is.EqualTo('m'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105663317));
                Assert.That(model.Value, Is.EqualTo('m'));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162616732));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('y'));

                importCollection.Clear();

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1185182541,
                    Value = 'g',
                    NullableValue = 'h'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1351455098,
                    Value = 'r',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1640961624,
                    Value = 'n',
                    NullableValue = 'q'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1713213418,
                    Value = 'e',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1717784456,
                    Value = 'm',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1728892275,
                    Value = 'w',
                    NullableValue = null
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1729812315,
                    Value = 's',
                    NullableValue = 'c'
                });

                importCollection.Add(
                new Charchar0MI
                {
                    Id = 1940932433,
                    Value = 'd',
                    NullableValue = 'o'
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(137233138));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142926684));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('f'));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(538208494));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(543249275));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('k'));


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1023072520));
                Assert.That(model.Value, Is.EqualTo('m'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1105663317));
                Assert.That(model.Value, Is.EqualTo('m'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1162616732));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('y'));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1185182541));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1351455098));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1640961624));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('q'));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1713213418));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1717784456));
                Assert.That(model.Value, Is.EqualTo('m'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1728892275));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1729812315));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1940932433));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('o'));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_charchar0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
charchar0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Charchar0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
FROM public.binary_charchar0m m
LEFT JOIN public.binary_charchar0mi mi ON mi.id = m.charchar0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Charchar0M),
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

                var importCollection = new List<Charchar0M>(15);

                importCollection.Add(
                new Charchar0M
                {
                    Id = 10754171,
                    Value = 'n',
                    NullableValue = 'x',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1162616732
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 140622805,
                    Value = 'p',
                    NullableValue = null,

                    ModelInner = new Charchar0MI 
                    {
                        Id = 137233138
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 218772351,
                    Value = 'v',
                    NullableValue = null,

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1940932433
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 259778914,
                    Value = 'e',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 299143368,
                    Value = 'i',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 311189983,
                    Value = 'g',
                    NullableValue = 'i',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1105663317
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 340094217,
                    Value = 'f',
                    NullableValue = 'n',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1023072520
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 443238142,
                    Value = 'b',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 491884600,
                    Value = 'x',
                    NullableValue = null,

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1351455098
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 495970124,
                    Value = 'r',
                    NullableValue = 'r',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1185182541
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 502615459,
                    Value = 'r',
                    NullableValue = 'h',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 546456252,
                    Value = 's',
                    NullableValue = null,

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1717784456
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 796856689,
                    Value = 'j',
                    NullableValue = 'u',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 142926684
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 858081174,
                    Value = 'e',
                    NullableValue = 'v',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1713213418
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 907332181,
                    Value = 'e',
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Charchar0M
                {
                    Id = 984889099,
                    Value = 'x',
                    NullableValue = 'm',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1004094797,
                    Value = 'x',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1069443446,
                    Value = 'q',
                    NullableValue = 'c',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1728892275
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1113401491,
                    Value = 'd',
                    NullableValue = 'x',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1122628690,
                    Value = 'y',
                    NullableValue = 'w',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1210710966,
                    Value = 's',
                    NullableValue = null,

                    ModelInner = new Charchar0MI 
                    {
                        Id = 543249275
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1225189137,
                    Value = 'w',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1276212086,
                    Value = 'x',
                    NullableValue = 'm',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1365497029,
                    Value = 'r',
                    NullableValue = 'm',

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1433659558,
                    Value = 'w',
                    NullableValue = 'p',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 538208494
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1459101644,
                    Value = 't',
                    NullableValue = 'g',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1640961624
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1591194653,
                    Value = 'r',
                    NullableValue = 'u',

                    ModelInner = new Charchar0MI 
                    {
                        Id = 1729812315
                    }

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1837542961,
                    Value = 'x',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 1910475342,
                    Value = 'k',
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Charchar0M
                {
                    Id = 2094011702,
                    Value = 'e',
                    NullableValue = 'r',

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(10754171));
                Assert.That(model.Value, Is.EqualTo('n'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1162616732));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('y'));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(140622805));
                Assert.That(model.Value, Is.EqualTo('p'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(137233138));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(218772351));
                Assert.That(model.Value, Is.EqualTo('v'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940932433));

                Assert.That(model.ModelInner.Value, Is.EqualTo('d'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('o'));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(259778914));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(299143368));
                Assert.That(model.Value, Is.EqualTo('i'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(311189983));
                Assert.That(model.Value, Is.EqualTo('g'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('i'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1105663317));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(340094217));
                Assert.That(model.Value, Is.EqualTo('f'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('n'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1023072520));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(443238142));
                Assert.That(model.Value, Is.EqualTo('b'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(491884600));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1351455098));

                Assert.That(model.ModelInner.Value, Is.EqualTo('r'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(495970124));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1185182541));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('h'));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(502615459));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('h'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(546456252));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717784456));

                Assert.That(model.ModelInner.Value, Is.EqualTo('m'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796856689));
                Assert.That(model.Value, Is.EqualTo('j'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(142926684));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('f'));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(858081174));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('v'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1713213418));

                Assert.That(model.ModelInner.Value, Is.EqualTo('e'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(907332181));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(984889099));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1004094797));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1069443446));
                Assert.That(model.Value, Is.EqualTo('q'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('c'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1728892275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('w'));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1113401491));
                Assert.That(model.Value, Is.EqualTo('d'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('x'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1122628690));
                Assert.That(model.Value, Is.EqualTo('y'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('w'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1210710966));
                Assert.That(model.Value, Is.EqualTo('s'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(543249275));

                Assert.That(model.ModelInner.Value, Is.EqualTo('y'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('k'));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1225189137));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1276212086));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1365497029));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('m'));

                Assert.That(model.ModelInner, Is.Null);


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1433659558));
                Assert.That(model.Value, Is.EqualTo('w'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('p'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(538208494));

                Assert.That(model.ModelInner.Value, Is.EqualTo('g'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1459101644));
                Assert.That(model.Value, Is.EqualTo('t'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('g'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1640961624));

                Assert.That(model.ModelInner.Value, Is.EqualTo('n'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('q'));


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591194653));
                Assert.That(model.Value, Is.EqualTo('r'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('u'));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1729812315));

                Assert.That(model.ModelInner.Value, Is.EqualTo('s'));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo('c'));


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1837542961));
                Assert.That(model.Value, Is.EqualTo('x'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1910475342));
                Assert.That(model.Value, Is.EqualTo('k'));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2094011702));
                Assert.That(model.Value, Is.EqualTo('e'));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo('r'));

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

        #endregion

#region BinaryExportModelInner

        #endregion

    }
}

