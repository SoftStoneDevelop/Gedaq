

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
    internal partial interface IDecimalSingleTypenumeric
    {
    }
    
    internal partial class DecimalSingleTypenumeric : IDecimalSingleTypenumeric
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0mi(
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
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0mi(
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
            queryMapType: typeof(Decimalnumeric0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
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

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModelInner(connection, 1300010952, 0.247699095601777m, 0.898491647698459m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModelInner(connection, 1463769788, 0.38139811215923m, null);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelInnerAsync(connection, 1751991380, 0.69718796044098m, 0.253892435043215m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelInnerAsync(connection, 1029796782, 0.987529865203918m, null);
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

                id =  ((IDecimalSingleTypenumeric)this).InsertModelInnerReturning(connection, 819730376, 0.776986420371594m, null);
                Assert.That(id, Is.EqualTo(819730376));

                id =  ((IDecimalSingleTypenumeric)this).InsertModelInnerReturning(connection, 622332448, 0.942757517983499m, 0.849514501585846m);
                Assert.That(id, Is.EqualTo(622332448));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, 1570885896, 0.486641631597378m, null);
                Assert.That(id, Is.EqualTo(1570885896));

                id = await ((IDecimalSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, 1354471680, 0.95282362778565m, null);
                Assert.That(id, Is.EqualTo(1354471680));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0mi(
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
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(7)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7), 
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

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModel(connection, 1080040472, 0.923919935738042m, null);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1268516295, 0.135627422981451m, 0.906068490781633m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1716180812, 0.549808289896416m, 0.771246291625178m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 2014351487, 0.587901106087643m, 0.0394748709938179m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1818425372, 0.80783794064781m, 0.586329498538407m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1046483528, 0.000949534869049473m, 0.592477832182737m);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 70002005, 0.251072204268882m, null);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0m(
	id,
    value,
    nullablevalue,
    decimalnumeric0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumeric0mi_id", 
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

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModel(connection, 558727647, 0.0143497203151857m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModel(connection, 255773286, 0.561635562567856m, null, 1300010952);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelAsync(connection, 90274152, 0.0608808243860451m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelAsync(connection, 117450385, 0.630944746179706m, null, 1463769788);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;

                nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturning(connection, 960717271, 0.168835344527154m, 0.485911657901187m, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.485911657901187m));

                nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturning(connection, 567875827, 0.839834948756372m, 0.473815215973525m, 1751991380);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.473815215973525m));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;

                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, 1272363670, 0.858182528478812m, 0.0869914942184346m, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.0869914942184346m));

                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, 812170014, 0.518431662872464m, null, 1029796782);

                Assert.That(nullable, Is.Null);

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0m(
	id,
    value,
    nullablevalue,
    decimalnumeric0mi_id
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
    decimalnumeric0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Decimalnumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumeric0mi_id", 
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
                List<Decimalnumeric0M> models = null;
                Decimalnumeric0M model = null;

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, 622451702, 0.352932861775132m, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, 1144004737, 0.857082134185719m, null, 819730376).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, 965839719, 0.578928456588441m, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, 1477116331, 0.284333764936851m, 0.738284329014934m, 622332448).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Decimalnumeric0M> models = null;
                Decimalnumeric0M model = null;

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, 1323397132, 0.471443934657161m, 0.251619203190607m, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, 18271430, 0.139711143976772m, null, 1570885896).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, 455929956, 0.647423189302185m, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, 1997507454, 0.961352625480964m, 0.253221689261392m, 1354471680).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumeric0m(
	id,
    value,
    nullablevalue,
    decimalnumeric0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimalnumeric0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Decimal), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimalnumeric0mi_id", 
                methodParametrName: "decimalnumeric0mi_id", 
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

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertModel(connection, 244826748, 0.869018423744349m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertModel(connection, 2079550184, 0.971589498511184m, null, 1080040472);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1879961660, 0.636391213491117m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1601040417, 0.827234341531638m, null, 1268516295);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 576935292, 0.389125276848779m, 0.859857479176704m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 479842045, 0.173716727376448m, 0.998128443900269m, 1716180812);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1423887528, 0.75330748168302m, 0.717704853068682m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1348396555, 0.0494225147302169m, 0.821484253066594m, 2014351487);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1346563635, 0.640890523778861m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 2074913339, 0.0886226981065423m, 0.801767654559412m, 1818425372);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1707719395, 0.128370176411188m, 0.419795621179096m, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 290772590, 0.0470297910539503m, null, 1046483528);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 861322041, 0.906947669386912m, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 2003494738, 0.332111063006279m, null, 70002005);
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
FROM public.decimalnumeric0m m
LEFT JOIN public.decimalnumeric0mi mi ON mi.id = m.decimalnumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Decimalnumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
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
                var models =  ((IDecimalSingleTypenumeric)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

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
FROM public.decimalnumeric0m m
LEFT JOIN public.decimalnumeric0mi mi ON mi.id = m.decimalnumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Decimalnumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
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
                var models =  ((IDecimalSingleTypenumeric)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 576935292);
                var models =  ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(19));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 1144004737);
                var models = await ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(13));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)
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
                 foreach(var batchResult in ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelBatch(connection, 1272363670, 1879961660))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

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
                await foreach(var batchResult in ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelBatchAsync(connection, 1423887528, 2003494738))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.decimalnumeric0m m
LEFT JOIN public.decimalnumeric0mi mi ON mi.id = m.decimalnumeric0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypenumeric)
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
                var models =  ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18271430)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.139711143976772m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1570885896)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.486641631597378m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90274152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0608808243860451m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117450385)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.630944746179706m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1463769788)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.38139811215923m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((244826748)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869018423744349m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((255773286)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.561635562567856m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1300010952)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.247699095601777m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.898491647698459m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((290772590)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0470297910539503m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1046483528)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.000949534869049473m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.592477832182737m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455929956)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.647423189302185m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((479842045)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.173716727376448m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1716180812)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.549808289896416m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.771246291625178m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.998128443900269m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558727647)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0143497203151857m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((567875827)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.839834948756372m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1751991380)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.69718796044098m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.253892435043215m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.473815215973525m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((576935292)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.389125276848779m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.859857479176704m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((622451702)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.352932861775132m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((812170014)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.518431662872464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1029796782)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.987529865203918m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((861322041)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.906947669386912m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((960717271)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.168835344527154m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.485911657901187m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((965839719)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.578928456588441m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1144004737)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.857082134185719m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((819730376)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.776986420371594m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1272363670)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.858182528478812m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0869914942184346m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1323397132)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.471443934657161m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.251619203190607m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1346563635)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640890523778861m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1348396555)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0494225147302169m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2014351487)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.587901106087643m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0394748709938179m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.821484253066594m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1423887528)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.75330748168302m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.717704853068682m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1477116331)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.284333764936851m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((622332448)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.942757517983499m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.849514501585846m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.738284329014934m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1601040417)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.827234341531638m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1268516295)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.135627422981451m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.906068490781633m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1707719395)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.128370176411188m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.419795621179096m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1879961660)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.636391213491117m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1997507454)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.961352625480964m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1354471680)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.95282362778565m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.253221689261392m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2003494738)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.332111063006279m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70002005)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.251072204268882m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2074913339)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0886226981065423m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1818425372)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.80783794064781m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.586329498538407m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.801767654559412m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2079550184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.971589498511184m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1080040472)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.923919935738042m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18271430)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.139711143976772m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1570885896)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.486641631597378m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90274152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0608808243860451m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117450385)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.630944746179706m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1463769788)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.38139811215923m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((244826748)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869018423744349m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((255773286)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.561635562567856m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1300010952)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.247699095601777m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.898491647698459m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((290772590)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0470297910539503m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1046483528)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.000949534869049473m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.592477832182737m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((455929956)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.647423189302185m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((479842045)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.173716727376448m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1716180812)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.549808289896416m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.771246291625178m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.998128443900269m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((558727647)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0143497203151857m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((567875827)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.839834948756372m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1751991380)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.69718796044098m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.253892435043215m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.473815215973525m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((576935292)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.389125276848779m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.859857479176704m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((622451702)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.352932861775132m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((812170014)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.518431662872464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1029796782)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.987529865203918m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((861322041)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.906947669386912m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((960717271)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.168835344527154m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.485911657901187m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((965839719)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.578928456588441m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1144004737)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.857082134185719m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((819730376)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.776986420371594m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1272363670)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.858182528478812m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0869914942184346m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1323397132)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.471443934657161m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.251619203190607m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1346563635)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640890523778861m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1348396555)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0494225147302169m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2014351487)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.587901106087643m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0394748709938179m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.821484253066594m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1423887528)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.75330748168302m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.717704853068682m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1477116331)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.284333764936851m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((622332448)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.942757517983499m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.849514501585846m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.738284329014934m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1601040417)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.827234341531638m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1268516295)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.135627422981451m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.906068490781633m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1707719395)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.128370176411188m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.419795621179096m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1879961660)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.636391213491117m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1997507454)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.961352625480964m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1354471680)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.95282362778565m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.253221689261392m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2003494738)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.332111063006279m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70002005)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.251072204268882m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2074913339)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0886226981065423m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1818425372)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.80783794064781m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.586329498538407m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.801767654559412m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2079550184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.971589498511184m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1080040472)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.923919935738042m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumeric0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Decimalnumeric0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
FROM public.binary_decimalnumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Decimalnumeric0MI),
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

                var importCollection = new List<Decimalnumeric0MI>(7);

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 70002005,
                    Value = 0.251072204268882m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 622332448,
                    Value = 0.942757517983499m,
                    NullableValue = 0.849514501585846m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 819730376,
                    Value = 0.776986420371594m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1029796782,
                    Value = 0.987529865203918m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1046483528,
                    Value = 0.000949534869049473m,
                    NullableValue = 0.592477832182737m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1080040472,
                    Value = 0.923919935738042m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1268516295,
                    Value = 0.135627422981451m,
                    NullableValue = 0.906068490781633m
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70002005));
                Assert.That(model.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622332448));
                Assert.That(model.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.849514501585846m));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819730376));
                Assert.That(model.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029796782));
                Assert.That(model.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046483528));
                Assert.That(model.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1080040472));
                Assert.That(model.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1268516295));
                Assert.That(model.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.906068490781633m));

                importCollection.Clear();

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1300010952,
                    Value = 0.247699095601777m,
                    NullableValue = 0.898491647698459m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1354471680,
                    Value = 0.95282362778565m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1463769788,
                    Value = 0.38139811215923m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1570885896,
                    Value = 0.486641631597378m,
                    NullableValue = null
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1716180812,
                    Value = 0.549808289896416m,
                    NullableValue = 0.771246291625178m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1751991380,
                    Value = 0.69718796044098m,
                    NullableValue = 0.253892435043215m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 1818425372,
                    Value = 0.80783794064781m,
                    NullableValue = 0.586329498538407m
                });

                importCollection.Add(
                new Decimalnumeric0MI
                {
                    Id = 2014351487,
                    Value = 0.587901106087643m,
                    NullableValue = 0.0394748709938179m
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(70002005));
                Assert.That(model.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622332448));
                Assert.That(model.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.849514501585846m));


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(819730376));
                Assert.That(model.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029796782));
                Assert.That(model.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1046483528));
                Assert.That(model.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.592477832182737m));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1080040472));
                Assert.That(model.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1268516295));
                Assert.That(model.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.906068490781633m));


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1300010952));
                Assert.That(model.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.898491647698459m));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1354471680));
                Assert.That(model.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1463769788));
                Assert.That(model.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570885896));
                Assert.That(model.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1716180812));
                Assert.That(model.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.771246291625178m));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751991380));
                Assert.That(model.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253892435043215m));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1818425372));
                Assert.That(model.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.586329498538407m));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2014351487));
                Assert.That(model.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0394748709938179m));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumeric0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumeric0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Decimalnumeric0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
FROM public.binary_decimalnumeric0m m
LEFT JOIN public.binary_decimalnumeric0mi mi ON mi.id = m.decimalnumeric0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Decimalnumeric0M),
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

                var importCollection = new List<Decimalnumeric0M>(15);

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 18271430,
                    Value = 0.139711143976772m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1570885896
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 90274152,
                    Value = 0.0608808243860451m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 117450385,
                    Value = 0.630944746179706m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1463769788
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 244826748,
                    Value = 0.869018423744349m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 255773286,
                    Value = 0.561635562567856m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1300010952
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 290772590,
                    Value = 0.0470297910539503m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1046483528
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 455929956,
                    Value = 0.647423189302185m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 479842045,
                    Value = 0.173716727376448m,
                    NullableValue = 0.998128443900269m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1716180812
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 558727647,
                    Value = 0.0143497203151857m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 567875827,
                    Value = 0.839834948756372m,
                    NullableValue = 0.473815215973525m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1751991380
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 576935292,
                    Value = 0.389125276848779m,
                    NullableValue = 0.859857479176704m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 622451702,
                    Value = 0.352932861775132m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 812170014,
                    Value = 0.518431662872464m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1029796782
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 861322041,
                    Value = 0.906947669386912m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 960717271,
                    Value = 0.168835344527154m,
                    NullableValue = 0.485911657901187m,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 965839719,
                    Value = 0.578928456588441m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1144004737,
                    Value = 0.857082134185719m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 819730376
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1272363670,
                    Value = 0.858182528478812m,
                    NullableValue = 0.0869914942184346m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1323397132,
                    Value = 0.471443934657161m,
                    NullableValue = 0.251619203190607m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1346563635,
                    Value = 0.640890523778861m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1348396555,
                    Value = 0.0494225147302169m,
                    NullableValue = 0.821484253066594m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 2014351487
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1423887528,
                    Value = 0.75330748168302m,
                    NullableValue = 0.717704853068682m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1477116331,
                    Value = 0.284333764936851m,
                    NullableValue = 0.738284329014934m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 622332448
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1601040417,
                    Value = 0.827234341531638m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1268516295
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1707719395,
                    Value = 0.128370176411188m,
                    NullableValue = 0.419795621179096m,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1879961660,
                    Value = 0.636391213491117m,
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 1997507454,
                    Value = 0.961352625480964m,
                    NullableValue = 0.253221689261392m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1354471680
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 2003494738,
                    Value = 0.332111063006279m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 70002005
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 2074913339,
                    Value = 0.0886226981065423m,
                    NullableValue = 0.801767654559412m,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1818425372
                    }

                });

                importCollection.Add(
                new Decimalnumeric0M
                {
                    Id = 2079550184,
                    Value = 0.971589498511184m,
                    NullableValue = null,

                    ModelInner = new Decimalnumeric0MI 
                    {
                        Id = 1080040472
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(18271430));
                Assert.That(model.Value, Is.EqualTo(0.139711143976772m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1570885896));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.486641631597378m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(90274152));
                Assert.That(model.Value, Is.EqualTo(0.0608808243860451m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(117450385));
                Assert.That(model.Value, Is.EqualTo(0.630944746179706m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1463769788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.38139811215923m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(244826748));
                Assert.That(model.Value, Is.EqualTo(0.869018423744349m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(255773286));
                Assert.That(model.Value, Is.EqualTo(0.561635562567856m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1300010952));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.247699095601777m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.898491647698459m));


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(290772590));
                Assert.That(model.Value, Is.EqualTo(0.0470297910539503m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1046483528));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.000949534869049473m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.592477832182737m));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(455929956));
                Assert.That(model.Value, Is.EqualTo(0.647423189302185m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(479842045));
                Assert.That(model.Value, Is.EqualTo(0.173716727376448m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.998128443900269m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1716180812));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.549808289896416m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.771246291625178m));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(558727647));
                Assert.That(model.Value, Is.EqualTo(0.0143497203151857m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(567875827));
                Assert.That(model.Value, Is.EqualTo(0.839834948756372m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.473815215973525m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1751991380));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.69718796044098m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.253892435043215m));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(576935292));
                Assert.That(model.Value, Is.EqualTo(0.389125276848779m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.859857479176704m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(622451702));
                Assert.That(model.Value, Is.EqualTo(0.352932861775132m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(812170014));
                Assert.That(model.Value, Is.EqualTo(0.518431662872464m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1029796782));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.987529865203918m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(861322041));
                Assert.That(model.Value, Is.EqualTo(0.906947669386912m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(960717271));
                Assert.That(model.Value, Is.EqualTo(0.168835344527154m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.485911657901187m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(965839719));
                Assert.That(model.Value, Is.EqualTo(0.578928456588441m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1144004737));
                Assert.That(model.Value, Is.EqualTo(0.857082134185719m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(819730376));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.776986420371594m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1272363670));
                Assert.That(model.Value, Is.EqualTo(0.858182528478812m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.0869914942184346m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1323397132));
                Assert.That(model.Value, Is.EqualTo(0.471443934657161m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.251619203190607m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1346563635));
                Assert.That(model.Value, Is.EqualTo(0.640890523778861m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1348396555));
                Assert.That(model.Value, Is.EqualTo(0.0494225147302169m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.821484253066594m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2014351487));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.587901106087643m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.0394748709938179m));


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423887528));
                Assert.That(model.Value, Is.EqualTo(0.75330748168302m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.717704853068682m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1477116331));
                Assert.That(model.Value, Is.EqualTo(0.284333764936851m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.738284329014934m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(622332448));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.942757517983499m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.849514501585846m));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1601040417));
                Assert.That(model.Value, Is.EqualTo(0.827234341531638m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1268516295));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.135627422981451m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.906068490781633m));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1707719395));
                Assert.That(model.Value, Is.EqualTo(0.128370176411188m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.419795621179096m));

                Assert.That(model.ModelInner, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1879961660));
                Assert.That(model.Value, Is.EqualTo(0.636391213491117m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1997507454));
                Assert.That(model.Value, Is.EqualTo(0.961352625480964m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.253221689261392m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1354471680));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.95282362778565m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2003494738));
                Assert.That(model.Value, Is.EqualTo(0.332111063006279m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(70002005));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.251072204268882m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2074913339));
                Assert.That(model.Value, Is.EqualTo(0.0886226981065423m));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(0.801767654559412m));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1818425372));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.80783794064781m));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(0.586329498538407m));


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2079550184));
                Assert.That(model.Value, Is.EqualTo(0.971589498511184m));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1080040472));

                Assert.That(model.ModelInner.Value, Is.EqualTo(0.923919935738042m));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumeric0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumeric0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Decimalnumeric0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
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

                var expected = new Dictionary<System.Int32,Decimalnumeric0M>(30);

                expected.Add(
                    18271430,
                    new Decimalnumeric0M
                    {
                        Id = 18271430,
                        Value = 0.139711143976772m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1570885896,
                            Value = 0.486641631597378m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    90274152,
                    new Decimalnumeric0M
                    {
                        Id = 90274152,
                        Value = 0.0608808243860451m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    117450385,
                    new Decimalnumeric0M
                    {
                        Id = 117450385,
                        Value = 0.630944746179706m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1463769788,
                            Value = 0.38139811215923m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    244826748,
                    new Decimalnumeric0M
                    {
                        Id = 244826748,
                        Value = 0.869018423744349m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    255773286,
                    new Decimalnumeric0M
                    {
                        Id = 255773286,
                        Value = 0.561635562567856m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1300010952,
                            Value = 0.247699095601777m,
                            NullableValue = 0.898491647698459m
                        }

                    }
                );

                expected.Add(
                    290772590,
                    new Decimalnumeric0M
                    {
                        Id = 290772590,
                        Value = 0.0470297910539503m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1046483528,
                            Value = 0.000949534869049473m,
                            NullableValue = 0.592477832182737m
                        }

                    }
                );

                expected.Add(
                    455929956,
                    new Decimalnumeric0M
                    {
                        Id = 455929956,
                        Value = 0.647423189302185m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    479842045,
                    new Decimalnumeric0M
                    {
                        Id = 479842045,
                        Value = 0.173716727376448m,
                        NullableValue = 0.998128443900269m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1716180812,
                            Value = 0.549808289896416m,
                            NullableValue = 0.771246291625178m
                        }

                    }
                );

                expected.Add(
                    558727647,
                    new Decimalnumeric0M
                    {
                        Id = 558727647,
                        Value = 0.0143497203151857m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    567875827,
                    new Decimalnumeric0M
                    {
                        Id = 567875827,
                        Value = 0.839834948756372m,
                        NullableValue = 0.473815215973525m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1751991380,
                            Value = 0.69718796044098m,
                            NullableValue = 0.253892435043215m
                        }

                    }
                );

                expected.Add(
                    576935292,
                    new Decimalnumeric0M
                    {
                        Id = 576935292,
                        Value = 0.389125276848779m,
                        NullableValue = 0.859857479176704m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    622451702,
                    new Decimalnumeric0M
                    {
                        Id = 622451702,
                        Value = 0.352932861775132m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    812170014,
                    new Decimalnumeric0M
                    {
                        Id = 812170014,
                        Value = 0.518431662872464m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1029796782,
                            Value = 0.987529865203918m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    861322041,
                    new Decimalnumeric0M
                    {
                        Id = 861322041,
                        Value = 0.906947669386912m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    960717271,
                    new Decimalnumeric0M
                    {
                        Id = 960717271,
                        Value = 0.168835344527154m,
                        NullableValue = 0.485911657901187m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    965839719,
                    new Decimalnumeric0M
                    {
                        Id = 965839719,
                        Value = 0.578928456588441m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1144004737,
                    new Decimalnumeric0M
                    {
                        Id = 1144004737,
                        Value = 0.857082134185719m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 819730376,
                            Value = 0.776986420371594m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1272363670,
                    new Decimalnumeric0M
                    {
                        Id = 1272363670,
                        Value = 0.858182528478812m,
                        NullableValue = 0.0869914942184346m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1323397132,
                    new Decimalnumeric0M
                    {
                        Id = 1323397132,
                        Value = 0.471443934657161m,
                        NullableValue = 0.251619203190607m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1346563635,
                    new Decimalnumeric0M
                    {
                        Id = 1346563635,
                        Value = 0.640890523778861m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1348396555,
                    new Decimalnumeric0M
                    {
                        Id = 1348396555,
                        Value = 0.0494225147302169m,
                        NullableValue = 0.821484253066594m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 2014351487,
                            Value = 0.587901106087643m,
                            NullableValue = 0.0394748709938179m
                        }

                    }
                );

                expected.Add(
                    1423887528,
                    new Decimalnumeric0M
                    {
                        Id = 1423887528,
                        Value = 0.75330748168302m,
                        NullableValue = 0.717704853068682m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1477116331,
                    new Decimalnumeric0M
                    {
                        Id = 1477116331,
                        Value = 0.284333764936851m,
                        NullableValue = 0.738284329014934m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 622332448,
                            Value = 0.942757517983499m,
                            NullableValue = 0.849514501585846m
                        }

                    }
                );

                expected.Add(
                    1601040417,
                    new Decimalnumeric0M
                    {
                        Id = 1601040417,
                        Value = 0.827234341531638m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1268516295,
                            Value = 0.135627422981451m,
                            NullableValue = 0.906068490781633m
                        }

                    }
                );

                expected.Add(
                    1707719395,
                    new Decimalnumeric0M
                    {
                        Id = 1707719395,
                        Value = 0.128370176411188m,
                        NullableValue = 0.419795621179096m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1879961660,
                    new Decimalnumeric0M
                    {
                        Id = 1879961660,
                        Value = 0.636391213491117m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1997507454,
                    new Decimalnumeric0M
                    {
                        Id = 1997507454,
                        Value = 0.961352625480964m,
                        NullableValue = 0.253221689261392m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1354471680,
                            Value = 0.95282362778565m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2003494738,
                    new Decimalnumeric0M
                    {
                        Id = 2003494738,
                        Value = 0.332111063006279m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 70002005,
                            Value = 0.251072204268882m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2074913339,
                    new Decimalnumeric0M
                    {
                        Id = 2074913339,
                        Value = 0.0886226981065423m,
                        NullableValue = 0.801767654559412m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1818425372,
                            Value = 0.80783794064781m,
                            NullableValue = 0.586329498538407m
                        }

                    }
                );

                expected.Add(
                    2079550184,
                    new Decimalnumeric0M
                    {
                        Id = 2079550184,
                        Value = 0.971589498511184m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1080040472,
                            Value = 0.923919935738042m,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
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

                var expected = new Dictionary<System.Int32,Decimalnumeric0M>(30);

                expected.Add(
                    18271430,
                    new Decimalnumeric0M
                    {
                        Id = 18271430,
                        Value = 0.139711143976772m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1570885896,
                            Value = 0.486641631597378m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    90274152,
                    new Decimalnumeric0M
                    {
                        Id = 90274152,
                        Value = 0.0608808243860451m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    117450385,
                    new Decimalnumeric0M
                    {
                        Id = 117450385,
                        Value = 0.630944746179706m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1463769788,
                            Value = 0.38139811215923m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    244826748,
                    new Decimalnumeric0M
                    {
                        Id = 244826748,
                        Value = 0.869018423744349m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    255773286,
                    new Decimalnumeric0M
                    {
                        Id = 255773286,
                        Value = 0.561635562567856m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1300010952,
                            Value = 0.247699095601777m,
                            NullableValue = 0.898491647698459m
                        }

                    }
                );

                expected.Add(
                    290772590,
                    new Decimalnumeric0M
                    {
                        Id = 290772590,
                        Value = 0.0470297910539503m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1046483528,
                            Value = 0.000949534869049473m,
                            NullableValue = 0.592477832182737m
                        }

                    }
                );

                expected.Add(
                    455929956,
                    new Decimalnumeric0M
                    {
                        Id = 455929956,
                        Value = 0.647423189302185m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    479842045,
                    new Decimalnumeric0M
                    {
                        Id = 479842045,
                        Value = 0.173716727376448m,
                        NullableValue = 0.998128443900269m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1716180812,
                            Value = 0.549808289896416m,
                            NullableValue = 0.771246291625178m
                        }

                    }
                );

                expected.Add(
                    558727647,
                    new Decimalnumeric0M
                    {
                        Id = 558727647,
                        Value = 0.0143497203151857m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    567875827,
                    new Decimalnumeric0M
                    {
                        Id = 567875827,
                        Value = 0.839834948756372m,
                        NullableValue = 0.473815215973525m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1751991380,
                            Value = 0.69718796044098m,
                            NullableValue = 0.253892435043215m
                        }

                    }
                );

                expected.Add(
                    576935292,
                    new Decimalnumeric0M
                    {
                        Id = 576935292,
                        Value = 0.389125276848779m,
                        NullableValue = 0.859857479176704m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    622451702,
                    new Decimalnumeric0M
                    {
                        Id = 622451702,
                        Value = 0.352932861775132m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    812170014,
                    new Decimalnumeric0M
                    {
                        Id = 812170014,
                        Value = 0.518431662872464m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1029796782,
                            Value = 0.987529865203918m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    861322041,
                    new Decimalnumeric0M
                    {
                        Id = 861322041,
                        Value = 0.906947669386912m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    960717271,
                    new Decimalnumeric0M
                    {
                        Id = 960717271,
                        Value = 0.168835344527154m,
                        NullableValue = 0.485911657901187m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    965839719,
                    new Decimalnumeric0M
                    {
                        Id = 965839719,
                        Value = 0.578928456588441m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1144004737,
                    new Decimalnumeric0M
                    {
                        Id = 1144004737,
                        Value = 0.857082134185719m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 819730376,
                            Value = 0.776986420371594m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1272363670,
                    new Decimalnumeric0M
                    {
                        Id = 1272363670,
                        Value = 0.858182528478812m,
                        NullableValue = 0.0869914942184346m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1323397132,
                    new Decimalnumeric0M
                    {
                        Id = 1323397132,
                        Value = 0.471443934657161m,
                        NullableValue = 0.251619203190607m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1346563635,
                    new Decimalnumeric0M
                    {
                        Id = 1346563635,
                        Value = 0.640890523778861m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1348396555,
                    new Decimalnumeric0M
                    {
                        Id = 1348396555,
                        Value = 0.0494225147302169m,
                        NullableValue = 0.821484253066594m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 2014351487,
                            Value = 0.587901106087643m,
                            NullableValue = 0.0394748709938179m
                        }

                    }
                );

                expected.Add(
                    1423887528,
                    new Decimalnumeric0M
                    {
                        Id = 1423887528,
                        Value = 0.75330748168302m,
                        NullableValue = 0.717704853068682m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1477116331,
                    new Decimalnumeric0M
                    {
                        Id = 1477116331,
                        Value = 0.284333764936851m,
                        NullableValue = 0.738284329014934m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 622332448,
                            Value = 0.942757517983499m,
                            NullableValue = 0.849514501585846m
                        }

                    }
                );

                expected.Add(
                    1601040417,
                    new Decimalnumeric0M
                    {
                        Id = 1601040417,
                        Value = 0.827234341531638m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1268516295,
                            Value = 0.135627422981451m,
                            NullableValue = 0.906068490781633m
                        }

                    }
                );

                expected.Add(
                    1707719395,
                    new Decimalnumeric0M
                    {
                        Id = 1707719395,
                        Value = 0.128370176411188m,
                        NullableValue = 0.419795621179096m,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1879961660,
                    new Decimalnumeric0M
                    {
                        Id = 1879961660,
                        Value = 0.636391213491117m,
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1997507454,
                    new Decimalnumeric0M
                    {
                        Id = 1997507454,
                        Value = 0.961352625480964m,
                        NullableValue = 0.253221689261392m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1354471680,
                            Value = 0.95282362778565m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2003494738,
                    new Decimalnumeric0M
                    {
                        Id = 2003494738,
                        Value = 0.332111063006279m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 70002005,
                            Value = 0.251072204268882m,
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2074913339,
                    new Decimalnumeric0M
                    {
                        Id = 2074913339,
                        Value = 0.0886226981065423m,
                        NullableValue = 0.801767654559412m,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1818425372,
                            Value = 0.80783794064781m,
                            NullableValue = 0.586329498538407m
                        }

                    }
                );

                expected.Add(
                    2079550184,
                    new Decimalnumeric0M
                    {
                        Id = 2079550184,
                        Value = 0.971589498511184m,
                        NullableValue = null,

                        ModelInner = new Decimalnumeric0MI
                        {
                            Id = 1080040472,
                            Value = 0.923919935738042m,
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Decimal)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Decimalnumeric0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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

                var expected = new Dictionary<System.Int32,Decimalnumeric0MI>(15);

                expected.Add(
                    70002005,
                    new Decimalnumeric0MI
                    {
                        Id = 70002005,
                        Value = 0.251072204268882m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    622332448,
                    new Decimalnumeric0MI
                    {
                        Id = 622332448,
                        Value = 0.942757517983499m,
                        NullableValue = 0.849514501585846m
                    }
                );

                expected.Add(
                    819730376,
                    new Decimalnumeric0MI
                    {
                        Id = 819730376,
                        Value = 0.776986420371594m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1029796782,
                    new Decimalnumeric0MI
                    {
                        Id = 1029796782,
                        Value = 0.987529865203918m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1046483528,
                    new Decimalnumeric0MI
                    {
                        Id = 1046483528,
                        Value = 0.000949534869049473m,
                        NullableValue = 0.592477832182737m
                    }
                );

                expected.Add(
                    1080040472,
                    new Decimalnumeric0MI
                    {
                        Id = 1080040472,
                        Value = 0.923919935738042m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1268516295,
                    new Decimalnumeric0MI
                    {
                        Id = 1268516295,
                        Value = 0.135627422981451m,
                        NullableValue = 0.906068490781633m
                    }
                );

                expected.Add(
                    1300010952,
                    new Decimalnumeric0MI
                    {
                        Id = 1300010952,
                        Value = 0.247699095601777m,
                        NullableValue = 0.898491647698459m
                    }
                );

                expected.Add(
                    1354471680,
                    new Decimalnumeric0MI
                    {
                        Id = 1354471680,
                        Value = 0.95282362778565m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1463769788,
                    new Decimalnumeric0MI
                    {
                        Id = 1463769788,
                        Value = 0.38139811215923m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1570885896,
                    new Decimalnumeric0MI
                    {
                        Id = 1570885896,
                        Value = 0.486641631597378m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1716180812,
                    new Decimalnumeric0MI
                    {
                        Id = 1716180812,
                        Value = 0.549808289896416m,
                        NullableValue = 0.771246291625178m
                    }
                );

                expected.Add(
                    1751991380,
                    new Decimalnumeric0MI
                    {
                        Id = 1751991380,
                        Value = 0.69718796044098m,
                        NullableValue = 0.253892435043215m
                    }
                );

                expected.Add(
                    1818425372,
                    new Decimalnumeric0MI
                    {
                        Id = 1818425372,
                        Value = 0.80783794064781m,
                        NullableValue = 0.586329498538407m
                    }
                );

                expected.Add(
                    2014351487,
                    new Decimalnumeric0MI
                    {
                        Id = 2014351487,
                        Value = 0.587901106087643m,
                        NullableValue = 0.0394748709938179m
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

                var expected = new Dictionary<System.Int32,Decimalnumeric0MI>(15);

                expected.Add(
                    70002005,
                    new Decimalnumeric0MI
                    {
                        Id = 70002005,
                        Value = 0.251072204268882m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    622332448,
                    new Decimalnumeric0MI
                    {
                        Id = 622332448,
                        Value = 0.942757517983499m,
                        NullableValue = 0.849514501585846m
                    }
                );

                expected.Add(
                    819730376,
                    new Decimalnumeric0MI
                    {
                        Id = 819730376,
                        Value = 0.776986420371594m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1029796782,
                    new Decimalnumeric0MI
                    {
                        Id = 1029796782,
                        Value = 0.987529865203918m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1046483528,
                    new Decimalnumeric0MI
                    {
                        Id = 1046483528,
                        Value = 0.000949534869049473m,
                        NullableValue = 0.592477832182737m
                    }
                );

                expected.Add(
                    1080040472,
                    new Decimalnumeric0MI
                    {
                        Id = 1080040472,
                        Value = 0.923919935738042m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1268516295,
                    new Decimalnumeric0MI
                    {
                        Id = 1268516295,
                        Value = 0.135627422981451m,
                        NullableValue = 0.906068490781633m
                    }
                );

                expected.Add(
                    1300010952,
                    new Decimalnumeric0MI
                    {
                        Id = 1300010952,
                        Value = 0.247699095601777m,
                        NullableValue = 0.898491647698459m
                    }
                );

                expected.Add(
                    1354471680,
                    new Decimalnumeric0MI
                    {
                        Id = 1354471680,
                        Value = 0.95282362778565m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1463769788,
                    new Decimalnumeric0MI
                    {
                        Id = 1463769788,
                        Value = 0.38139811215923m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1570885896,
                    new Decimalnumeric0MI
                    {
                        Id = 1570885896,
                        Value = 0.486641631597378m,
                        NullableValue = null
                    }
                );

                expected.Add(
                    1716180812,
                    new Decimalnumeric0MI
                    {
                        Id = 1716180812,
                        Value = 0.549808289896416m,
                        NullableValue = 0.771246291625178m
                    }
                );

                expected.Add(
                    1751991380,
                    new Decimalnumeric0MI
                    {
                        Id = 1751991380,
                        Value = 0.69718796044098m,
                        NullableValue = 0.253892435043215m
                    }
                );

                expected.Add(
                    1818425372,
                    new Decimalnumeric0MI
                    {
                        Id = 1818425372,
                        Value = 0.80783794064781m,
                        NullableValue = 0.586329498538407m
                    }
                );

                expected.Add(
                    2014351487,
                    new Decimalnumeric0MI
                    {
                        Id = 2014351487,
                        Value = 0.587901106087643m,
                        NullableValue = 0.0394748709938179m
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

