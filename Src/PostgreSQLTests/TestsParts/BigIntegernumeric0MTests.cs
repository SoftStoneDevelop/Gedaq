

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
    internal partial interface IBigIntegerSingleTypenumeric
    {
    }
    
    internal partial class BigIntegerSingleTypenumeric : IBigIntegerSingleTypenumeric
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
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
INSERT INTO public.bigintegernumeric0mi(
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
            queryMapType: typeof(BigIntegernumeric0MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, 970941230, new System.Numerics.BigInteger(8487319472269510369L), new System.Numerics.BigInteger(2783047314144945882L));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, 1937126352, new System.Numerics.BigInteger(4057365546898105456L), new System.Numerics.BigInteger(5955280074207954541L));
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, 1843888631, new System.Numerics.BigInteger(2410591407151173527L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, 608737047, new System.Numerics.BigInteger(8878088054861698475L), null);
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

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, 395393761, new System.Numerics.BigInteger(7816948259689088742L), new System.Numerics.BigInteger(2026991853140898545L));
                Assert.That(id, Is.EqualTo(395393761));

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, 1567491748, new System.Numerics.BigInteger(890384903118242957L), null);
                Assert.That(id, Is.EqualTo(1567491748));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, 1394779016, new System.Numerics.BigInteger(5015763468787781072L), null);
                Assert.That(id, Is.EqualTo(1394779016));

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, 943793800, new System.Numerics.BigInteger(7569712322399742768L), null);
                Assert.That(id, Is.EqualTo(943793800));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(7)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModel(connection, 718380474, new System.Numerics.BigInteger(6340446495533048929L), new System.Numerics.BigInteger(3501806784189290851L));
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 821094110, new System.Numerics.BigInteger(4740172929123753133L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1993839996, new System.Numerics.BigInteger(3873605822795282644L), new System.Numerics.BigInteger(1196764673136123890L));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1378348788, new System.Numerics.BigInteger(5365444797256594846L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1897303619, new System.Numerics.BigInteger(6950410771772961192L), new System.Numerics.BigInteger(1248257436508518674L));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1574706059, new System.Numerics.BigInteger(1992268541598051887L), new System.Numerics.BigInteger(1979870678944098855L));
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, 1874273765, new System.Numerics.BigInteger(2151226107687843561L), new System.Numerics.BigInteger(4063905803048131207L));
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumeric0mi_id", 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, 1918809615, new System.Numerics.BigInteger(9174085149243226674L), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, 1584165605, new System.Numerics.BigInteger(5916011549481469360L), null, 970941230);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, 1081038877, new System.Numerics.BigInteger(7665401687189042595L), new System.Numerics.BigInteger(5752468901716933013L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, 1721811558, new System.Numerics.BigInteger(860268042007003595L), new System.Numerics.BigInteger(6828452650127410680L), 1937126352);
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
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
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
    bigintegernumeric0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(BigIntegernumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumeric0mi_id", 
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
                List<BigIntegernumeric0M> models = null;
                BigIntegernumeric0M model = null;

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, 950247846, new System.Numerics.BigInteger(9214800819408296390L), new System.Numerics.BigInteger(2398018641561314023L), null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, 1308137385, new System.Numerics.BigInteger(8582258432332975296L), null, 1843888631).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, 31713344, new System.Numerics.BigInteger(7312800983314465958L), null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, 359991033, new System.Numerics.BigInteger(2563860047395729337L), null, 608737047).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumeric0M> models = null;
                BigIntegernumeric0M model = null;

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, 398839201, new System.Numerics.BigInteger(1704261586039149470L), null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, 796878811, new System.Numerics.BigInteger(1928811930391838265L), null, 395393761).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, 2058948027, new System.Numerics.BigInteger(2756681125898065204L), new System.Numerics.BigInteger(7076901584804132596L), null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, 1444337158, new System.Numerics.BigInteger(4083915602280886306L), null, 1567491748).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumeric0m(
	id,
    value,
    nullablevalue,
    bigintegernumeric0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bigintegernumeric0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Numerics.BigInteger), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7),
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bigintegernumeric0mi_id", 
                methodParametrName: "bigintegernumeric0mi_id", 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, 1309162120, new System.Numerics.BigInteger(7487242492381764567L), new System.Numerics.BigInteger(1229287412442266508L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, 202833317, new System.Numerics.BigInteger(6060914166013600063L), new System.Numerics.BigInteger(3121762965694990212L), 1394779016);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1924908788, new System.Numerics.BigInteger(1986503381762580560L), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 979822403, new System.Numerics.BigInteger(6498607373905790999L), new System.Numerics.BigInteger(7717405081089631553L), 943793800);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 2110653797, new System.Numerics.BigInteger(2446475842141487436L), new System.Numerics.BigInteger(9216094158264192778L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 516508270, new System.Numerics.BigInteger(3067699651161955896L), new System.Numerics.BigInteger(5916640634853704285L), 718380474);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 142152914, new System.Numerics.BigInteger(642144678861735656L), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 357335189, new System.Numerics.BigInteger(2982847513031591801L), null, 821094110);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 108340378, new System.Numerics.BigInteger(5297052577377800627L), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1570073433, new System.Numerics.BigInteger(4924911210321921615L), null, 1993839996);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 625972964, new System.Numerics.BigInteger(8670895261089842715L), new System.Numerics.BigInteger(8755549028973512595L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1796000891, new System.Numerics.BigInteger(4940313262328727370L), null, 1378348788);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 425558688, new System.Numerics.BigInteger(7041164164071579470L), new System.Numerics.BigInteger(6958693469267934342L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1156326490, new System.Numerics.BigInteger(5292935145450324127L), null, 1897303619);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1101143564, new System.Numerics.BigInteger(7715845960322076624L), null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 367274753, new System.Numerics.BigInteger(8348510262836981718L), new System.Numerics.BigInteger(6611034542946395935L), 1574706059);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 7744473, new System.Numerics.BigInteger(7263152452357225843L), new System.Numerics.BigInteger(7044327011336619516L), null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, 1801155184, new System.Numerics.BigInteger(2449923571490038827L), new System.Numerics.BigInteger(5552645565935447533L), 1874273765);
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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(BigIntegernumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(BigIntegernumeric0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 1584165605);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(7));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 625972964);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(18));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
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
                 foreach(var batchResult in ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelBatch(connection, 1081038877, 1570073433))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(14));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(8));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

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
                await foreach(var batchResult in ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelBatchAsync(connection, 1584165605, 1796000891))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

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
FROM public.bigintegernumeric0m m
LEFT JOIN public.bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7744473)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7263152452357225843L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7044327011336619516L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31713344)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7312800983314465958L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108340378)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5297052577377800627L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142152914)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(642144678861735656L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202833317)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6060914166013600063L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1394779016)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5015763468787781072L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3121762965694990212L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((357335189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2982847513031591801L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821094110)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4740172929123753133L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((359991033)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2563860047395729337L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((608737047)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8878088054861698475L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((367274753)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8348510262836981718L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1574706059)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1992268541598051887L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1979870678944098855L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6611034542946395935L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((398839201)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1704261586039149470L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((425558688)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7041164164071579470L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6958693469267934342L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((516508270)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3067699651161955896L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((718380474)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6340446495533048929L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3501806784189290851L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5916640634853704285L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((625972964)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8670895261089842715L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8755549028973512595L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((796878811)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1928811930391838265L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((395393761)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7816948259689088742L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2026991853140898545L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950247846)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9214800819408296390L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2398018641561314023L))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((979822403)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6498607373905790999L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((943793800)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7569712322399742768L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7717405081089631553L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1081038877)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7665401687189042595L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5752468901716933013L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1101143564)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7715845960322076624L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1156326490)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5292935145450324127L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1897303619)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6950410771772961192L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1248257436508518674L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1308137385)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8582258432332975296L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1843888631)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2410591407151173527L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1309162120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7487242492381764567L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1229287412442266508L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1444337158)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4083915602280886306L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1567491748)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(890384903118242957L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1570073433)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4924911210321921615L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1993839996)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3873605822795282644L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1196764673136123890L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1584165605)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5916011549481469360L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((970941230)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8487319472269510369L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2783047314144945882L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1721811558)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(860268042007003595L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937126352)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4057365546898105456L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5955280074207954541L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6828452650127410680L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1796000891)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4940313262328727370L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1378348788)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5365444797256594846L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1801155184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2449923571490038827L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1874273765)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2151226107687843561L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4063905803048131207L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5552645565935447533L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1918809615)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9174085149243226674L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1924908788)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1986503381762580560L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2058948027)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2756681125898065204L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7076901584804132596L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2110653797)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2446475842141487436L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9216094158264192778L))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7744473)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7263152452357225843L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7044327011336619516L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31713344)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7312800983314465958L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108340378)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5297052577377800627L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142152914)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(642144678861735656L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((202833317)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6060914166013600063L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1394779016)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5015763468787781072L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3121762965694990212L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((357335189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2982847513031591801L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((821094110)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4740172929123753133L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((359991033)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2563860047395729337L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((608737047)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8878088054861698475L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((367274753)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8348510262836981718L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1574706059)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1992268541598051887L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1979870678944098855L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6611034542946395935L))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((398839201)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1704261586039149470L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((425558688)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7041164164071579470L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6958693469267934342L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((516508270)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3067699651161955896L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((718380474)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6340446495533048929L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3501806784189290851L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5916640634853704285L))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((625972964)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8670895261089842715L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8755549028973512595L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((796878811)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1928811930391838265L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((395393761)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7816948259689088742L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2026991853140898545L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((950247846)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9214800819408296390L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2398018641561314023L))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((979822403)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6498607373905790999L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((943793800)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7569712322399742768L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7717405081089631553L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1081038877)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7665401687189042595L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5752468901716933013L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1101143564)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7715845960322076624L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1156326490)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5292935145450324127L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1897303619)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6950410771772961192L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1248257436508518674L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1308137385)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8582258432332975296L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1843888631)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2410591407151173527L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1309162120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7487242492381764567L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1229287412442266508L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1444337158)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4083915602280886306L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1567491748)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(890384903118242957L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1570073433)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4924911210321921615L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1993839996)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3873605822795282644L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1196764673136123890L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1584165605)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5916011549481469360L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((970941230)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8487319472269510369L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2783047314144945882L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1721811558)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(860268042007003595L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1937126352)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4057365546898105456L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5955280074207954541L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6828452650127410680L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1796000891)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4940313262328727370L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1378348788)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5365444797256594846L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1801155184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2449923571490038827L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1874273765)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2151226107687843561L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4063905803048131207L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5552645565935447533L))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1918809615)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9174085149243226674L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1924908788)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1986503381762580560L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2058948027)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2756681125898065204L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7076901584804132596L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2110653797)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2446475842141487436L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(9216094158264192778L))));

            }
        }

        #endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MI),
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
FROM public.binary_bigintegernumeric0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(BigIntegernumeric0MI),
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

                var importCollection = new List<BigIntegernumeric0MI>(7);

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 395393761,
                    Value = new System.Numerics.BigInteger(7816948259689088742L),
                    NullableValue = new System.Numerics.BigInteger(2026991853140898545L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 608737047,
                    Value = new System.Numerics.BigInteger(8878088054861698475L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 718380474,
                    Value = new System.Numerics.BigInteger(6340446495533048929L),
                    NullableValue = new System.Numerics.BigInteger(3501806784189290851L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 821094110,
                    Value = new System.Numerics.BigInteger(4740172929123753133L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 943793800,
                    Value = new System.Numerics.BigInteger(7569712322399742768L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 970941230,
                    Value = new System.Numerics.BigInteger(8487319472269510369L),
                    NullableValue = new System.Numerics.BigInteger(2783047314144945882L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1378348788,
                    Value = new System.Numerics.BigInteger(5365444797256594846L),
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(395393761));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608737047));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(718380474));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821094110));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943793800));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970941230));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378348788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1394779016,
                    Value = new System.Numerics.BigInteger(5015763468787781072L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1567491748,
                    Value = new System.Numerics.BigInteger(890384903118242957L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1574706059,
                    Value = new System.Numerics.BigInteger(1992268541598051887L),
                    NullableValue = new System.Numerics.BigInteger(1979870678944098855L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1843888631,
                    Value = new System.Numerics.BigInteger(2410591407151173527L),
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1874273765,
                    Value = new System.Numerics.BigInteger(2151226107687843561L),
                    NullableValue = new System.Numerics.BigInteger(4063905803048131207L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1897303619,
                    Value = new System.Numerics.BigInteger(6950410771772961192L),
                    NullableValue = new System.Numerics.BigInteger(1248257436508518674L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1937126352,
                    Value = new System.Numerics.BigInteger(4057365546898105456L),
                    NullableValue = new System.Numerics.BigInteger(5955280074207954541L)
                });

                importCollection.Add(
                new BigIntegernumeric0MI
                {
                    Id = 1993839996,
                    Value = new System.Numerics.BigInteger(3873605822795282644L),
                    NullableValue = new System.Numerics.BigInteger(1196764673136123890L)
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(395393761));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608737047));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(718380474));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(821094110));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(943793800));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(970941230));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1378348788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1394779016));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1567491748));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1574706059));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1843888631));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.NullableValue, Is.Null);


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1874273765));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1897303619));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1937126352));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1993839996));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));


            }
        }

        #endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumeric0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumeric0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumeric0M),
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
FROM public.binary_bigintegernumeric0m m
LEFT JOIN public.binary_bigintegernumeric0mi mi ON mi.id = m.bigintegernumeric0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(BigIntegernumeric0M),
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

                var importCollection = new List<BigIntegernumeric0M>(15);

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 7744473,
                    Value = new System.Numerics.BigInteger(7263152452357225843L),
                    NullableValue = new System.Numerics.BigInteger(7044327011336619516L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 31713344,
                    Value = new System.Numerics.BigInteger(7312800983314465958L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 108340378,
                    Value = new System.Numerics.BigInteger(5297052577377800627L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 142152914,
                    Value = new System.Numerics.BigInteger(642144678861735656L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 202833317,
                    Value = new System.Numerics.BigInteger(6060914166013600063L),
                    NullableValue = new System.Numerics.BigInteger(3121762965694990212L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1394779016
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 357335189,
                    Value = new System.Numerics.BigInteger(2982847513031591801L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 821094110
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 359991033,
                    Value = new System.Numerics.BigInteger(2563860047395729337L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 608737047
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 367274753,
                    Value = new System.Numerics.BigInteger(8348510262836981718L),
                    NullableValue = new System.Numerics.BigInteger(6611034542946395935L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1574706059
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 398839201,
                    Value = new System.Numerics.BigInteger(1704261586039149470L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 425558688,
                    Value = new System.Numerics.BigInteger(7041164164071579470L),
                    NullableValue = new System.Numerics.BigInteger(6958693469267934342L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 516508270,
                    Value = new System.Numerics.BigInteger(3067699651161955896L),
                    NullableValue = new System.Numerics.BigInteger(5916640634853704285L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 718380474
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 625972964,
                    Value = new System.Numerics.BigInteger(8670895261089842715L),
                    NullableValue = new System.Numerics.BigInteger(8755549028973512595L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 796878811,
                    Value = new System.Numerics.BigInteger(1928811930391838265L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 395393761
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 950247846,
                    Value = new System.Numerics.BigInteger(9214800819408296390L),
                    NullableValue = new System.Numerics.BigInteger(2398018641561314023L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 979822403,
                    Value = new System.Numerics.BigInteger(6498607373905790999L),
                    NullableValue = new System.Numerics.BigInteger(7717405081089631553L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 943793800
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                importCollection.Clear();

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1081038877,
                    Value = new System.Numerics.BigInteger(7665401687189042595L),
                    NullableValue = new System.Numerics.BigInteger(5752468901716933013L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1101143564,
                    Value = new System.Numerics.BigInteger(7715845960322076624L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1156326490,
                    Value = new System.Numerics.BigInteger(5292935145450324127L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1897303619
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1308137385,
                    Value = new System.Numerics.BigInteger(8582258432332975296L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1843888631
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1309162120,
                    Value = new System.Numerics.BigInteger(7487242492381764567L),
                    NullableValue = new System.Numerics.BigInteger(1229287412442266508L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1444337158,
                    Value = new System.Numerics.BigInteger(4083915602280886306L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1567491748
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1570073433,
                    Value = new System.Numerics.BigInteger(4924911210321921615L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1993839996
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1584165605,
                    Value = new System.Numerics.BigInteger(5916011549481469360L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 970941230
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1721811558,
                    Value = new System.Numerics.BigInteger(860268042007003595L),
                    NullableValue = new System.Numerics.BigInteger(6828452650127410680L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1937126352
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1796000891,
                    Value = new System.Numerics.BigInteger(4940313262328727370L),
                    NullableValue = null,

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1378348788
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1801155184,
                    Value = new System.Numerics.BigInteger(2449923571490038827L),
                    NullableValue = new System.Numerics.BigInteger(5552645565935447533L),

                    ModelInner = new BigIntegernumeric0MI 
                    {
                        Id = 1874273765
                    }

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1918809615,
                    Value = new System.Numerics.BigInteger(9174085149243226674L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 1924908788,
                    Value = new System.Numerics.BigInteger(1986503381762580560L),
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 2058948027,
                    Value = new System.Numerics.BigInteger(2756681125898065204L),
                    NullableValue = new System.Numerics.BigInteger(7076901584804132596L),

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumeric0M
                {
                    Id = 2110653797,
                    Value = new System.Numerics.BigInteger(2446475842141487436L),
                    NullableValue = new System.Numerics.BigInteger(9216094158264192778L),

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(7744473));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7263152452357225843L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7044327011336619516L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(31713344));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7312800983314465958L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(108340378));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5297052577377800627L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(142152914));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(642144678861735656L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(202833317));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6060914166013600063L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3121762965694990212L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1394779016));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5015763468787781072L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(357335189));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2982847513031591801L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(821094110));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4740172929123753133L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(359991033));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2563860047395729337L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(608737047));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8878088054861698475L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(367274753));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8348510262836981718L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6611034542946395935L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1574706059));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(1992268541598051887L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1979870678944098855L)));


                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(398839201));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1704261586039149470L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(425558688));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7041164164071579470L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6958693469267934342L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(516508270));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(3067699651161955896L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5916640634853704285L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(718380474));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6340446495533048929L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(3501806784189290851L)));


                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(625972964));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8670895261089842715L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(8755549028973512595L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(796878811));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1928811930391838265L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(395393761));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7816948259689088742L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2026991853140898545L)));


                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(950247846));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9214800819408296390L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2398018641561314023L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(979822403));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(6498607373905790999L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7717405081089631553L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943793800));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(7569712322399742768L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1081038877));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7665401687189042595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5752468901716933013L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1101143564));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7715845960322076624L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1156326490));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5292935145450324127L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1897303619));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(6950410771772961192L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1248257436508518674L)));


                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1308137385));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(8582258432332975296L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1843888631));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2410591407151173527L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1309162120));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(7487242492381764567L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1229287412442266508L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1444337158));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4083915602280886306L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1567491748));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(890384903118242957L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1570073433));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4924911210321921615L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1993839996));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(3873605822795282644L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(1196764673136123890L)));


                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1584165605));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(5916011549481469360L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(970941230));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(8487319472269510369L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(2783047314144945882L)));


                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1721811558));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(860268042007003595L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(6828452650127410680L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1937126352));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(4057365546898105456L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5955280074207954541L)));


                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1796000891));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(4940313262328727370L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1378348788));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(5365444797256594846L)));

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1801155184));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2449923571490038827L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(5552645565935447533L)));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1874273765));

                Assert.That(model.ModelInner.Value, Is.EqualTo(new System.Numerics.BigInteger(2151226107687843561L)));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(4063905803048131207L)));


                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918809615));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(9174085149243226674L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1924908788));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(1986503381762580560L)));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2058948027));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2756681125898065204L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(7076901584804132596L)));

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2110653797));
                Assert.That(model.Value, Is.EqualTo(new System.Numerics.BigInteger(2446475842141487436L)));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(new System.Numerics.BigInteger(9216094158264192778L)));

                Assert.That(model.ModelInner, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumeric0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumeric0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(BigIntegernumeric0M),
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

                var expected = new Dictionary<System.Int32,BigIntegernumeric0M>(30);

                expected.Add(
                    7744473,
                    new BigIntegernumeric0M
                    {
                        Id = 7744473,
                        Value = new System.Numerics.BigInteger(7263152452357225843L),
                        NullableValue = new System.Numerics.BigInteger(7044327011336619516L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    31713344,
                    new BigIntegernumeric0M
                    {
                        Id = 31713344,
                        Value = new System.Numerics.BigInteger(7312800983314465958L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    108340378,
                    new BigIntegernumeric0M
                    {
                        Id = 108340378,
                        Value = new System.Numerics.BigInteger(5297052577377800627L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    142152914,
                    new BigIntegernumeric0M
                    {
                        Id = 142152914,
                        Value = new System.Numerics.BigInteger(642144678861735656L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    202833317,
                    new BigIntegernumeric0M
                    {
                        Id = 202833317,
                        Value = new System.Numerics.BigInteger(6060914166013600063L),
                        NullableValue = new System.Numerics.BigInteger(3121762965694990212L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1394779016,
                            Value = new System.Numerics.BigInteger(5015763468787781072L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    357335189,
                    new BigIntegernumeric0M
                    {
                        Id = 357335189,
                        Value = new System.Numerics.BigInteger(2982847513031591801L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 821094110,
                            Value = new System.Numerics.BigInteger(4740172929123753133L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    359991033,
                    new BigIntegernumeric0M
                    {
                        Id = 359991033,
                        Value = new System.Numerics.BigInteger(2563860047395729337L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 608737047,
                            Value = new System.Numerics.BigInteger(8878088054861698475L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    367274753,
                    new BigIntegernumeric0M
                    {
                        Id = 367274753,
                        Value = new System.Numerics.BigInteger(8348510262836981718L),
                        NullableValue = new System.Numerics.BigInteger(6611034542946395935L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1574706059,
                            Value = new System.Numerics.BigInteger(1992268541598051887L),
                            NullableValue = new System.Numerics.BigInteger(1979870678944098855L)
                        }

                    }
                );

                expected.Add(
                    398839201,
                    new BigIntegernumeric0M
                    {
                        Id = 398839201,
                        Value = new System.Numerics.BigInteger(1704261586039149470L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    425558688,
                    new BigIntegernumeric0M
                    {
                        Id = 425558688,
                        Value = new System.Numerics.BigInteger(7041164164071579470L),
                        NullableValue = new System.Numerics.BigInteger(6958693469267934342L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    516508270,
                    new BigIntegernumeric0M
                    {
                        Id = 516508270,
                        Value = new System.Numerics.BigInteger(3067699651161955896L),
                        NullableValue = new System.Numerics.BigInteger(5916640634853704285L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 718380474,
                            Value = new System.Numerics.BigInteger(6340446495533048929L),
                            NullableValue = new System.Numerics.BigInteger(3501806784189290851L)
                        }

                    }
                );

                expected.Add(
                    625972964,
                    new BigIntegernumeric0M
                    {
                        Id = 625972964,
                        Value = new System.Numerics.BigInteger(8670895261089842715L),
                        NullableValue = new System.Numerics.BigInteger(8755549028973512595L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    796878811,
                    new BigIntegernumeric0M
                    {
                        Id = 796878811,
                        Value = new System.Numerics.BigInteger(1928811930391838265L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 395393761,
                            Value = new System.Numerics.BigInteger(7816948259689088742L),
                            NullableValue = new System.Numerics.BigInteger(2026991853140898545L)
                        }

                    }
                );

                expected.Add(
                    950247846,
                    new BigIntegernumeric0M
                    {
                        Id = 950247846,
                        Value = new System.Numerics.BigInteger(9214800819408296390L),
                        NullableValue = new System.Numerics.BigInteger(2398018641561314023L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    979822403,
                    new BigIntegernumeric0M
                    {
                        Id = 979822403,
                        Value = new System.Numerics.BigInteger(6498607373905790999L),
                        NullableValue = new System.Numerics.BigInteger(7717405081089631553L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 943793800,
                            Value = new System.Numerics.BigInteger(7569712322399742768L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1081038877,
                    new BigIntegernumeric0M
                    {
                        Id = 1081038877,
                        Value = new System.Numerics.BigInteger(7665401687189042595L),
                        NullableValue = new System.Numerics.BigInteger(5752468901716933013L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1101143564,
                    new BigIntegernumeric0M
                    {
                        Id = 1101143564,
                        Value = new System.Numerics.BigInteger(7715845960322076624L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1156326490,
                    new BigIntegernumeric0M
                    {
                        Id = 1156326490,
                        Value = new System.Numerics.BigInteger(5292935145450324127L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1897303619,
                            Value = new System.Numerics.BigInteger(6950410771772961192L),
                            NullableValue = new System.Numerics.BigInteger(1248257436508518674L)
                        }

                    }
                );

                expected.Add(
                    1308137385,
                    new BigIntegernumeric0M
                    {
                        Id = 1308137385,
                        Value = new System.Numerics.BigInteger(8582258432332975296L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1843888631,
                            Value = new System.Numerics.BigInteger(2410591407151173527L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1309162120,
                    new BigIntegernumeric0M
                    {
                        Id = 1309162120,
                        Value = new System.Numerics.BigInteger(7487242492381764567L),
                        NullableValue = new System.Numerics.BigInteger(1229287412442266508L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1444337158,
                    new BigIntegernumeric0M
                    {
                        Id = 1444337158,
                        Value = new System.Numerics.BigInteger(4083915602280886306L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1567491748,
                            Value = new System.Numerics.BigInteger(890384903118242957L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1570073433,
                    new BigIntegernumeric0M
                    {
                        Id = 1570073433,
                        Value = new System.Numerics.BigInteger(4924911210321921615L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1993839996,
                            Value = new System.Numerics.BigInteger(3873605822795282644L),
                            NullableValue = new System.Numerics.BigInteger(1196764673136123890L)
                        }

                    }
                );

                expected.Add(
                    1584165605,
                    new BigIntegernumeric0M
                    {
                        Id = 1584165605,
                        Value = new System.Numerics.BigInteger(5916011549481469360L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 970941230,
                            Value = new System.Numerics.BigInteger(8487319472269510369L),
                            NullableValue = new System.Numerics.BigInteger(2783047314144945882L)
                        }

                    }
                );

                expected.Add(
                    1721811558,
                    new BigIntegernumeric0M
                    {
                        Id = 1721811558,
                        Value = new System.Numerics.BigInteger(860268042007003595L),
                        NullableValue = new System.Numerics.BigInteger(6828452650127410680L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1937126352,
                            Value = new System.Numerics.BigInteger(4057365546898105456L),
                            NullableValue = new System.Numerics.BigInteger(5955280074207954541L)
                        }

                    }
                );

                expected.Add(
                    1796000891,
                    new BigIntegernumeric0M
                    {
                        Id = 1796000891,
                        Value = new System.Numerics.BigInteger(4940313262328727370L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1378348788,
                            Value = new System.Numerics.BigInteger(5365444797256594846L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1801155184,
                    new BigIntegernumeric0M
                    {
                        Id = 1801155184,
                        Value = new System.Numerics.BigInteger(2449923571490038827L),
                        NullableValue = new System.Numerics.BigInteger(5552645565935447533L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1874273765,
                            Value = new System.Numerics.BigInteger(2151226107687843561L),
                            NullableValue = new System.Numerics.BigInteger(4063905803048131207L)
                        }

                    }
                );

                expected.Add(
                    1918809615,
                    new BigIntegernumeric0M
                    {
                        Id = 1918809615,
                        Value = new System.Numerics.BigInteger(9174085149243226674L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1924908788,
                    new BigIntegernumeric0M
                    {
                        Id = 1924908788,
                        Value = new System.Numerics.BigInteger(1986503381762580560L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2058948027,
                    new BigIntegernumeric0M
                    {
                        Id = 2058948027,
                        Value = new System.Numerics.BigInteger(2756681125898065204L),
                        NullableValue = new System.Numerics.BigInteger(7076901584804132596L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2110653797,
                    new BigIntegernumeric0M
                    {
                        Id = 2110653797,
                        Value = new System.Numerics.BigInteger(2446475842141487436L),
                        NullableValue = new System.Numerics.BigInteger(9216094158264192778L),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
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

                var expected = new Dictionary<System.Int32,BigIntegernumeric0M>(30);

                expected.Add(
                    7744473,
                    new BigIntegernumeric0M
                    {
                        Id = 7744473,
                        Value = new System.Numerics.BigInteger(7263152452357225843L),
                        NullableValue = new System.Numerics.BigInteger(7044327011336619516L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    31713344,
                    new BigIntegernumeric0M
                    {
                        Id = 31713344,
                        Value = new System.Numerics.BigInteger(7312800983314465958L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    108340378,
                    new BigIntegernumeric0M
                    {
                        Id = 108340378,
                        Value = new System.Numerics.BigInteger(5297052577377800627L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    142152914,
                    new BigIntegernumeric0M
                    {
                        Id = 142152914,
                        Value = new System.Numerics.BigInteger(642144678861735656L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    202833317,
                    new BigIntegernumeric0M
                    {
                        Id = 202833317,
                        Value = new System.Numerics.BigInteger(6060914166013600063L),
                        NullableValue = new System.Numerics.BigInteger(3121762965694990212L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1394779016,
                            Value = new System.Numerics.BigInteger(5015763468787781072L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    357335189,
                    new BigIntegernumeric0M
                    {
                        Id = 357335189,
                        Value = new System.Numerics.BigInteger(2982847513031591801L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 821094110,
                            Value = new System.Numerics.BigInteger(4740172929123753133L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    359991033,
                    new BigIntegernumeric0M
                    {
                        Id = 359991033,
                        Value = new System.Numerics.BigInteger(2563860047395729337L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 608737047,
                            Value = new System.Numerics.BigInteger(8878088054861698475L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    367274753,
                    new BigIntegernumeric0M
                    {
                        Id = 367274753,
                        Value = new System.Numerics.BigInteger(8348510262836981718L),
                        NullableValue = new System.Numerics.BigInteger(6611034542946395935L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1574706059,
                            Value = new System.Numerics.BigInteger(1992268541598051887L),
                            NullableValue = new System.Numerics.BigInteger(1979870678944098855L)
                        }

                    }
                );

                expected.Add(
                    398839201,
                    new BigIntegernumeric0M
                    {
                        Id = 398839201,
                        Value = new System.Numerics.BigInteger(1704261586039149470L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    425558688,
                    new BigIntegernumeric0M
                    {
                        Id = 425558688,
                        Value = new System.Numerics.BigInteger(7041164164071579470L),
                        NullableValue = new System.Numerics.BigInteger(6958693469267934342L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    516508270,
                    new BigIntegernumeric0M
                    {
                        Id = 516508270,
                        Value = new System.Numerics.BigInteger(3067699651161955896L),
                        NullableValue = new System.Numerics.BigInteger(5916640634853704285L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 718380474,
                            Value = new System.Numerics.BigInteger(6340446495533048929L),
                            NullableValue = new System.Numerics.BigInteger(3501806784189290851L)
                        }

                    }
                );

                expected.Add(
                    625972964,
                    new BigIntegernumeric0M
                    {
                        Id = 625972964,
                        Value = new System.Numerics.BigInteger(8670895261089842715L),
                        NullableValue = new System.Numerics.BigInteger(8755549028973512595L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    796878811,
                    new BigIntegernumeric0M
                    {
                        Id = 796878811,
                        Value = new System.Numerics.BigInteger(1928811930391838265L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 395393761,
                            Value = new System.Numerics.BigInteger(7816948259689088742L),
                            NullableValue = new System.Numerics.BigInteger(2026991853140898545L)
                        }

                    }
                );

                expected.Add(
                    950247846,
                    new BigIntegernumeric0M
                    {
                        Id = 950247846,
                        Value = new System.Numerics.BigInteger(9214800819408296390L),
                        NullableValue = new System.Numerics.BigInteger(2398018641561314023L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    979822403,
                    new BigIntegernumeric0M
                    {
                        Id = 979822403,
                        Value = new System.Numerics.BigInteger(6498607373905790999L),
                        NullableValue = new System.Numerics.BigInteger(7717405081089631553L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 943793800,
                            Value = new System.Numerics.BigInteger(7569712322399742768L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1081038877,
                    new BigIntegernumeric0M
                    {
                        Id = 1081038877,
                        Value = new System.Numerics.BigInteger(7665401687189042595L),
                        NullableValue = new System.Numerics.BigInteger(5752468901716933013L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1101143564,
                    new BigIntegernumeric0M
                    {
                        Id = 1101143564,
                        Value = new System.Numerics.BigInteger(7715845960322076624L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1156326490,
                    new BigIntegernumeric0M
                    {
                        Id = 1156326490,
                        Value = new System.Numerics.BigInteger(5292935145450324127L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1897303619,
                            Value = new System.Numerics.BigInteger(6950410771772961192L),
                            NullableValue = new System.Numerics.BigInteger(1248257436508518674L)
                        }

                    }
                );

                expected.Add(
                    1308137385,
                    new BigIntegernumeric0M
                    {
                        Id = 1308137385,
                        Value = new System.Numerics.BigInteger(8582258432332975296L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1843888631,
                            Value = new System.Numerics.BigInteger(2410591407151173527L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1309162120,
                    new BigIntegernumeric0M
                    {
                        Id = 1309162120,
                        Value = new System.Numerics.BigInteger(7487242492381764567L),
                        NullableValue = new System.Numerics.BigInteger(1229287412442266508L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    1444337158,
                    new BigIntegernumeric0M
                    {
                        Id = 1444337158,
                        Value = new System.Numerics.BigInteger(4083915602280886306L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1567491748,
                            Value = new System.Numerics.BigInteger(890384903118242957L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1570073433,
                    new BigIntegernumeric0M
                    {
                        Id = 1570073433,
                        Value = new System.Numerics.BigInteger(4924911210321921615L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1993839996,
                            Value = new System.Numerics.BigInteger(3873605822795282644L),
                            NullableValue = new System.Numerics.BigInteger(1196764673136123890L)
                        }

                    }
                );

                expected.Add(
                    1584165605,
                    new BigIntegernumeric0M
                    {
                        Id = 1584165605,
                        Value = new System.Numerics.BigInteger(5916011549481469360L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 970941230,
                            Value = new System.Numerics.BigInteger(8487319472269510369L),
                            NullableValue = new System.Numerics.BigInteger(2783047314144945882L)
                        }

                    }
                );

                expected.Add(
                    1721811558,
                    new BigIntegernumeric0M
                    {
                        Id = 1721811558,
                        Value = new System.Numerics.BigInteger(860268042007003595L),
                        NullableValue = new System.Numerics.BigInteger(6828452650127410680L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1937126352,
                            Value = new System.Numerics.BigInteger(4057365546898105456L),
                            NullableValue = new System.Numerics.BigInteger(5955280074207954541L)
                        }

                    }
                );

                expected.Add(
                    1796000891,
                    new BigIntegernumeric0M
                    {
                        Id = 1796000891,
                        Value = new System.Numerics.BigInteger(4940313262328727370L),
                        NullableValue = null,

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1378348788,
                            Value = new System.Numerics.BigInteger(5365444797256594846L),
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1801155184,
                    new BigIntegernumeric0M
                    {
                        Id = 1801155184,
                        Value = new System.Numerics.BigInteger(2449923571490038827L),
                        NullableValue = new System.Numerics.BigInteger(5552645565935447533L),

                        ModelInner = new BigIntegernumeric0MI
                        {
                            Id = 1874273765,
                            Value = new System.Numerics.BigInteger(2151226107687843561L),
                            NullableValue = new System.Numerics.BigInteger(4063905803048131207L)
                        }

                    }
                );

                expected.Add(
                    1918809615,
                    new BigIntegernumeric0M
                    {
                        Id = 1918809615,
                        Value = new System.Numerics.BigInteger(9174085149243226674L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1924908788,
                    new BigIntegernumeric0M
                    {
                        Id = 1924908788,
                        Value = new System.Numerics.BigInteger(1986503381762580560L),
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2058948027,
                    new BigIntegernumeric0M
                    {
                        Id = 2058948027,
                        Value = new System.Numerics.BigInteger(2756681125898065204L),
                        NullableValue = new System.Numerics.BigInteger(7076901584804132596L),

                        ModelInner = null

                    }
                );

                expected.Add(
                    2110653797,
                    new BigIntegernumeric0M
                    {
                        Id = 2110653797,
                        Value = new System.Numerics.BigInteger(2446475842141487436L),
                        NullableValue = new System.Numerics.BigInteger(9216094158264192778L),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(BigIntegernumeric0MI),
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

                var expected = new Dictionary<System.Int32,BigIntegernumeric0MI>(15);

                expected.Add(
                    395393761,
                    new BigIntegernumeric0MI
                    {
                        Id = 395393761,
                        Value = new System.Numerics.BigInteger(7816948259689088742L),
                        NullableValue = new System.Numerics.BigInteger(2026991853140898545L)
                    }
                );

                expected.Add(
                    608737047,
                    new BigIntegernumeric0MI
                    {
                        Id = 608737047,
                        Value = new System.Numerics.BigInteger(8878088054861698475L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    718380474,
                    new BigIntegernumeric0MI
                    {
                        Id = 718380474,
                        Value = new System.Numerics.BigInteger(6340446495533048929L),
                        NullableValue = new System.Numerics.BigInteger(3501806784189290851L)
                    }
                );

                expected.Add(
                    821094110,
                    new BigIntegernumeric0MI
                    {
                        Id = 821094110,
                        Value = new System.Numerics.BigInteger(4740172929123753133L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    943793800,
                    new BigIntegernumeric0MI
                    {
                        Id = 943793800,
                        Value = new System.Numerics.BigInteger(7569712322399742768L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    970941230,
                    new BigIntegernumeric0MI
                    {
                        Id = 970941230,
                        Value = new System.Numerics.BigInteger(8487319472269510369L),
                        NullableValue = new System.Numerics.BigInteger(2783047314144945882L)
                    }
                );

                expected.Add(
                    1378348788,
                    new BigIntegernumeric0MI
                    {
                        Id = 1378348788,
                        Value = new System.Numerics.BigInteger(5365444797256594846L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1394779016,
                    new BigIntegernumeric0MI
                    {
                        Id = 1394779016,
                        Value = new System.Numerics.BigInteger(5015763468787781072L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1567491748,
                    new BigIntegernumeric0MI
                    {
                        Id = 1567491748,
                        Value = new System.Numerics.BigInteger(890384903118242957L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1574706059,
                    new BigIntegernumeric0MI
                    {
                        Id = 1574706059,
                        Value = new System.Numerics.BigInteger(1992268541598051887L),
                        NullableValue = new System.Numerics.BigInteger(1979870678944098855L)
                    }
                );

                expected.Add(
                    1843888631,
                    new BigIntegernumeric0MI
                    {
                        Id = 1843888631,
                        Value = new System.Numerics.BigInteger(2410591407151173527L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1874273765,
                    new BigIntegernumeric0MI
                    {
                        Id = 1874273765,
                        Value = new System.Numerics.BigInteger(2151226107687843561L),
                        NullableValue = new System.Numerics.BigInteger(4063905803048131207L)
                    }
                );

                expected.Add(
                    1897303619,
                    new BigIntegernumeric0MI
                    {
                        Id = 1897303619,
                        Value = new System.Numerics.BigInteger(6950410771772961192L),
                        NullableValue = new System.Numerics.BigInteger(1248257436508518674L)
                    }
                );

                expected.Add(
                    1937126352,
                    new BigIntegernumeric0MI
                    {
                        Id = 1937126352,
                        Value = new System.Numerics.BigInteger(4057365546898105456L),
                        NullableValue = new System.Numerics.BigInteger(5955280074207954541L)
                    }
                );

                expected.Add(
                    1993839996,
                    new BigIntegernumeric0MI
                    {
                        Id = 1993839996,
                        Value = new System.Numerics.BigInteger(3873605822795282644L),
                        NullableValue = new System.Numerics.BigInteger(1196764673136123890L)
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

                var expected = new Dictionary<System.Int32,BigIntegernumeric0MI>(15);

                expected.Add(
                    395393761,
                    new BigIntegernumeric0MI
                    {
                        Id = 395393761,
                        Value = new System.Numerics.BigInteger(7816948259689088742L),
                        NullableValue = new System.Numerics.BigInteger(2026991853140898545L)
                    }
                );

                expected.Add(
                    608737047,
                    new BigIntegernumeric0MI
                    {
                        Id = 608737047,
                        Value = new System.Numerics.BigInteger(8878088054861698475L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    718380474,
                    new BigIntegernumeric0MI
                    {
                        Id = 718380474,
                        Value = new System.Numerics.BigInteger(6340446495533048929L),
                        NullableValue = new System.Numerics.BigInteger(3501806784189290851L)
                    }
                );

                expected.Add(
                    821094110,
                    new BigIntegernumeric0MI
                    {
                        Id = 821094110,
                        Value = new System.Numerics.BigInteger(4740172929123753133L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    943793800,
                    new BigIntegernumeric0MI
                    {
                        Id = 943793800,
                        Value = new System.Numerics.BigInteger(7569712322399742768L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    970941230,
                    new BigIntegernumeric0MI
                    {
                        Id = 970941230,
                        Value = new System.Numerics.BigInteger(8487319472269510369L),
                        NullableValue = new System.Numerics.BigInteger(2783047314144945882L)
                    }
                );

                expected.Add(
                    1378348788,
                    new BigIntegernumeric0MI
                    {
                        Id = 1378348788,
                        Value = new System.Numerics.BigInteger(5365444797256594846L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1394779016,
                    new BigIntegernumeric0MI
                    {
                        Id = 1394779016,
                        Value = new System.Numerics.BigInteger(5015763468787781072L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1567491748,
                    new BigIntegernumeric0MI
                    {
                        Id = 1567491748,
                        Value = new System.Numerics.BigInteger(890384903118242957L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1574706059,
                    new BigIntegernumeric0MI
                    {
                        Id = 1574706059,
                        Value = new System.Numerics.BigInteger(1992268541598051887L),
                        NullableValue = new System.Numerics.BigInteger(1979870678944098855L)
                    }
                );

                expected.Add(
                    1843888631,
                    new BigIntegernumeric0MI
                    {
                        Id = 1843888631,
                        Value = new System.Numerics.BigInteger(2410591407151173527L),
                        NullableValue = null
                    }
                );

                expected.Add(
                    1874273765,
                    new BigIntegernumeric0MI
                    {
                        Id = 1874273765,
                        Value = new System.Numerics.BigInteger(2151226107687843561L),
                        NullableValue = new System.Numerics.BigInteger(4063905803048131207L)
                    }
                );

                expected.Add(
                    1897303619,
                    new BigIntegernumeric0MI
                    {
                        Id = 1897303619,
                        Value = new System.Numerics.BigInteger(6950410771772961192L),
                        NullableValue = new System.Numerics.BigInteger(1248257436508518674L)
                    }
                );

                expected.Add(
                    1937126352,
                    new BigIntegernumeric0MI
                    {
                        Id = 1937126352,
                        Value = new System.Numerics.BigInteger(4057365546898105456L),
                        NullableValue = new System.Numerics.BigInteger(5955280074207954541L)
                    }
                );

                expected.Add(
                    1993839996,
                    new BigIntegernumeric0MI
                    {
                        Id = 1993839996,
                        Value = new System.Numerics.BigInteger(3873605822795282644L),
                        NullableValue = new System.Numerics.BigInteger(1196764673136123890L)
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

