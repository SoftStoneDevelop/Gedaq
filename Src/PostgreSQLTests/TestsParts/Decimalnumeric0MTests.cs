

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


#region TestData

        private readonly Decimalnumeric0M[] _testData = new Decimalnumeric0M[]
        {
            new Decimalnumeric0M
{
    Id = 9,
    Value = 0.270919406957768m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 11,
    Value = 0.446554366322073m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 7,
    Value = 0.0281510930441903m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 20,
    Value = 0.0186055458891696m,
    ModelInner = null,
    NullableValue = 0.556463312294462m,
},
            new Decimalnumeric0M
{
    Id = 21,
    Value = 0.213189289461994m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 12,
    Value = 0.259121462163439m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 26,
    Value = 0.846608964588191m,
    ModelInner = null,
    NullableValue = 0.366234027773523m,
},
            new Decimalnumeric0M
{
    Id = 34,
    Value = 0.0583839569274249m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 13,
    Value = 0.767388015805865m,
    NullableValue = 0.717807963770882m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 42,
    Value = 0.989824513802915m,
    ModelInner = null,
    NullableValue = 0.528017571195867m,
},
            new Decimalnumeric0M
{
    Id = 51,
    Value = 0.990720994128256m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 18,
    Value = 0.490964734424112m,
    NullableValue = null,
},
    NullableValue = 0.329944549376999m,
},
            new Decimalnumeric0M
{
    Id = 55,
    Value = 0.706313851404875m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 63,
    Value = 0.780124064874962m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 24,
    Value = 0.281943901432751m,
    NullableValue = 0.704103396360986m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 66,
    Value = 0.83404672600427m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 73,
    Value = 0.982163800347464m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 31,
    Value = 0.287407080480032m,
    NullableValue = 0.734583117210799m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 78,
    Value = 0.61082450349223m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 87,
    Value = 0.99843620149682m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 40,
    Value = 0.279553449814274m,
    NullableValue = 0.126508047634252m,
},
    NullableValue = 0.315985388226908m,
},
            new Decimalnumeric0M
{
    Id = 88,
    Value = 0.132117261925424m,
    ModelInner = null,
    NullableValue = 0.414322813254764m,
},
            new Decimalnumeric0M
{
    Id = 95,
    Value = 0.717585085808464m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 46,
    Value = 0.193290211385315m,
    NullableValue = 0.20875285627668m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 102,
    Value = 0.602790706529143m,
    ModelInner = null,
    NullableValue = 0.806710798310545m,
},
            new Decimalnumeric0M
{
    Id = 109,
    Value = 0.53256360333m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 47,
    Value = 0.829729625432284m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 115,
    Value = 0.32905333568268m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 123,
    Value = 0.689129956446864m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 51,
    Value = 0.499439827013551m,
    NullableValue = 0.980944648340764m,
},
    NullableValue = 0.799794446596523m,
},
            new Decimalnumeric0M
{
    Id = 128,
    Value = 0.979137444527651m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 130,
    Value = 0.261182362036351m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 59,
    Value = 0.82091249412198m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 135,
    Value = 0.167201157219742m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 143,
    Value = 0.875609229442924m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 62,
    Value = 0.394069004371633m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 147,
    Value = 0.758197894812802m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 150,
    Value = 0.0452809253463887m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 68,
    Value = 0.00284285630051106m,
    NullableValue = null,
},
    NullableValue = 0.590505604041163m,
},
            new Decimalnumeric0M
{
    Id = 159,
    Value = 0.383900456237503m,
    ModelInner = null,
    NullableValue = 0.183130208830754m,
},
            new Decimalnumeric0M
{
    Id = 163,
    Value = 0.441995035612527m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 72,
    Value = 0.698429816101309m,
    NullableValue = null,
},
    NullableValue = 0.366940086631966m,
},
            new Decimalnumeric0M
{
    Id = 169,
    Value = 0.373667619868831m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 172,
    Value = 0.245045769909357m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 80,
    Value = 0.968259809881278m,
    NullableValue = 0.226216169276424m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 181,
    Value = 0.753484396626995m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 184,
    Value = 0.615341713596609m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 86,
    Value = 0.760782506085012m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 189,
    Value = 0.261402908654033m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 192,
    Value = 0.168325727413077m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 94,
    Value = 0.48032040731638m,
    NullableValue = 0.430385525440984m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 194,
    Value = 0.974272099587428m,
    ModelInner = null,
    NullableValue = 0.435473504784297m,
},
        };

#endregion

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
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
            queryMapTypes: [typeof(Decimalnumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
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

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDecimalSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7), 
                nullable: true)]
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

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumeric0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalSingleTypenumeric)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalSingleTypenumeric)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
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
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Decimalnumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.366234027773523m));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.528017571195867m));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(13);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.329944549376999m));
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
            queryMapTypes: [typeof(Decimalnumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumeric0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Decimalnumeric0M> models = null;

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Decimalnumeric0M> models = null;

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Decimalnumeric0M.AssertModel(models[0],_testData[19], true);
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
            queryMapTypes: null,
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
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimalnumeric0mi_id", 
                methodParametrName: "decimalnumeric0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
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

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumeric0M), typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalSingleTypenumeric)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalSingleTypenumeric)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Decimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalSingleTypenumeric)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalSingleTypenumeric)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumeric0M), typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
            queryMapTypes: [typeof(Decimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalSingleTypenumeric)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumeric0M), typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                await((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 189;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 181;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 189;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[34], false);
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
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Decimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypenumeric)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Decimalnumeric0M.AssertModel(models[0],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Decimalnumeric0M.AssertModel(models[0],_testData[1], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[2], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[3], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[4], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[5], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[6], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[7], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[8], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[9], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[10], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[11], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[19],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[20],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[21],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[22],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[23],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[24],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[25],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[26],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[27],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[28],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[29],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[30],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[31],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[32],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 189;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Decimalnumeric0M.AssertModel(models[0],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Decimalnumeric0M.AssertModel(models[0],_testData[1], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[2], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[3], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[4], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[5], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[6], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[7], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[8], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[9], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[10], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[11], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[19],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[20],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[21],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[22],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[23],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[24],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[25],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[26],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[27],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[28],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[29],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[30],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[31],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[32],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumeric0M), typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                await((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumeric0M>();
                var models2 = new List<FlatDecimalnumeric0M>();
                ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumeric0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var firstItems2 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 184, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumeric0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems1 = new List<FlatDecimalnumeric0M>();
                var secondItems2 = new List<FlatDecimalnumeric0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 169, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[24],_testData[34], false);
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
            queryMapTypes: [typeof(Decimalnumeric0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Decimalnumeric0M.AssertModel(models[0],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Decimalnumeric0M.AssertModel(models[0],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[19],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[20],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[21],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalSingleTypenumeric)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimalnumeric0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 128, 172))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Decimalnumeric0M.AssertModel(models[0],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[29], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Decimalnumeric0M.AssertModel(models[0],_testData[30], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[31], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[32], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[33], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 184);
                var models = await ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Decimalnumeric0M.AssertModel(models[0],_testData[32], false);
                Decimalnumeric0M.AssertModel(models[1],_testData[33], false);
                Decimalnumeric0M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Decimalnumeric0M.AssertModel(models[0],_testData[12], false);
                Decimalnumeric0M.AssertModel(models[1],_testData[13], false);
                Decimalnumeric0M.AssertModel(models[2],_testData[14], false);
                Decimalnumeric0M.AssertModel(models[3],_testData[15], false);
                Decimalnumeric0M.AssertModel(models[4],_testData[16], false);
                Decimalnumeric0M.AssertModel(models[5],_testData[17], false);
                Decimalnumeric0M.AssertModel(models[6],_testData[18], false);
                Decimalnumeric0M.AssertModel(models[7],_testData[19], false);
                Decimalnumeric0M.AssertModel(models[8],_testData[20], false);
                Decimalnumeric0M.AssertModel(models[9],_testData[21], false);
                Decimalnumeric0M.AssertModel(models[10],_testData[22], false);
                Decimalnumeric0M.AssertModel(models[11],_testData[23], false);
                Decimalnumeric0M.AssertModel(models[12],_testData[24], false);
                Decimalnumeric0M.AssertModel(models[13],_testData[25], false);
                Decimalnumeric0M.AssertModel(models[14],_testData[26], false);
                Decimalnumeric0M.AssertModel(models[15],_testData[27], false);
                Decimalnumeric0M.AssertModel(models[16],_testData[28], false);
                Decimalnumeric0M.AssertModel(models[17],_testData[29], false);
                Decimalnumeric0M.AssertModel(models[18],_testData[30], false);
                Decimalnumeric0M.AssertModel(models[19],_testData[31], false);
                Decimalnumeric0M.AssertModel(models[20],_testData[32], false);
                Decimalnumeric0M.AssertModel(models[21],_testData[33], false);
                Decimalnumeric0M.AssertModel(models[22],_testData[34], false);
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
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.270919406957768m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.446554366322073m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0281510930441903m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0186055458891696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.556463312294462m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.213189289461994m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.259121462163439m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.846608964588191m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366234027773523m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0583839569274249m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.767388015805865m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.717807963770882m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989824513802915m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.528017571195867m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.990720994128256m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.490964734424112m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.329944549376999m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.706313851404875m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.780124064874962m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.281943901432751m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.704103396360986m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.83404672600427m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.982163800347464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.287407080480032m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.734583117210799m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.61082450349223m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.99843620149682m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.279553449814274m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.126508047634252m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.315985388226908m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.132117261925424m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.414322813254764m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.717585085808464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.193290211385315m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.20875285627668m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.602790706529143m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.806710798310545m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53256360333m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.829729625432284m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32905333568268m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.689129956446864m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.499439827013551m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.980944648340764m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.799794446596523m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.979137444527651m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261182362036351m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.82091249412198m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.167201157219742m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875609229442924m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.394069004371633m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.758197894812802m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0452809253463887m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.00284285630051106m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.590505604041163m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.383900456237503m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.183130208830754m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.441995035612527m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.698429816101309m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366940086631966m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.373667619868831m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.245045769909357m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.968259809881278m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.226216169276424m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.753484396626995m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.615341713596609m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.760782506085012m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261402908654033m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.168325727413077m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.48032040731638m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.430385525440984m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.974272099587428m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.435473504784297m)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.270919406957768m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.446554366322073m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0281510930441903m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0186055458891696m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.556463312294462m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.213189289461994m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.259121462163439m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.846608964588191m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366234027773523m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0583839569274249m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.767388015805865m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.717807963770882m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989824513802915m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.528017571195867m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.990720994128256m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.490964734424112m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.329944549376999m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.706313851404875m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.780124064874962m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.281943901432751m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.704103396360986m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.83404672600427m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.982163800347464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.287407080480032m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.734583117210799m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.61082450349223m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.99843620149682m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.279553449814274m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.126508047634252m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.315985388226908m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.132117261925424m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.414322813254764m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.717585085808464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.193290211385315m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.20875285627668m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.602790706529143m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.806710798310545m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53256360333m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.829729625432284m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32905333568268m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.689129956446864m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.499439827013551m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.980944648340764m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.799794446596523m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.979137444527651m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261182362036351m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.82091249412198m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.167201157219742m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875609229442924m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.394069004371633m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.758197894812802m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0452809253463887m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.00284285630051106m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.590505604041163m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.383900456237503m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.183130208830754m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.441995035612527m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.698429816101309m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.366940086631966m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.373667619868831m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.245045769909357m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.968259809881278m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.226216169276424m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.753484396626995m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.615341713596609m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.760782506085012m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261402908654033m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.168325727413077m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.48032040731638m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.430385525440984m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.974272099587428m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.435473504784297m)));

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Decimalnumeric0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypenumeric)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalSingleTypenumeric)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypenumeric)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalSingleTypenumeric)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Decimalnumeric0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypenumeric)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalSingleTypenumeric)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypenumeric)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalSingleTypenumeric)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Decimalnumeric0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalSingleTypenumeric)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypenumeric)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Decimalnumeric0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalSingleTypenumeric)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalSingleTypenumeric)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
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
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumeric0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Decimalnumeric0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Decimalnumeric0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Decimalnumeric0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
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
            queryMapTypes: [typeof(Decimalnumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Decimalnumeric0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalSingleTypenumeric)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypenumeric)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Decimalnumeric0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Decimalnumeric0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalSingleTypenumeric)this).ImportModel(connection, importCollection);
                var models = ((IDecimalSingleTypenumeric)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Decimalnumeric0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapTypes: [typeof(Decimalnumeric0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypenumeric)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Decimalnumeric0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Decimalnumeric0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA), typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                await ((IDecimalSingleTypenumeric)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                ((IDecimalSingleTypenumeric)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalSingleTypenumeric)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalSingleTypenumeric)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA), typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                await ((IDecimalSingleTypenumeric)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                ((IDecimalSingleTypenumeric)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalSingleTypenumeric)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalSingleTypenumeric)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MI), typeof(Decimalnumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MI>();
                var models2 = new List<Decimalnumeric0MI>();
                await ((IDecimalSingleTypenumeric)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MI>();
                var models2 = new List<Decimalnumeric0MI>();
                ((IDecimalSingleTypenumeric)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalSingleTypenumeric)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalSingleTypenumeric)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumeric0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA), typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                await ((IDecimalSingleTypenumeric)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Decimalnumeric0MIWA>();
                var models2 = new List<Decimalnumeric0MIWA>();
                ((IDecimalSingleTypenumeric)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumeric0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalSingleTypenumeric)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalSingleTypenumeric)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

