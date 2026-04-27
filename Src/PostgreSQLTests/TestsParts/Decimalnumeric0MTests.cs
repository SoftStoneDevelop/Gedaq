

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
    Id = 6,
    Value = 0.0457280939832466m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 8,
    Value = 0.88793570483551m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 2,
    Value = 0.901092417432652m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 15,
    Value = 0.485917021818525m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 18,
    Value = 0.3173030435495m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 9,
    Value = 0.545326702119133m,
    NullableValue = 0.151741956244085m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 27,
    Value = 0.126226885077491m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 36,
    Value = 0.900123437433812m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 15,
    Value = 0.928026296590762m,
    NullableValue = null,
},
    NullableValue = 0.373306394703574m,
},
            new Decimalnumeric0M
{
    Id = 39,
    Value = 0.698415189456558m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 48,
    Value = 0.0451391990202364m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 18,
    Value = 0.0645728305935538m,
    NullableValue = 0.274770600740436m,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 53,
    Value = 0.898393030599832m,
    ModelInner = null,
    NullableValue = 0.590842449980694m,
},
            new Decimalnumeric0M
{
    Id = 54,
    Value = 0.16156368627936m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 23,
    Value = 0.430598575494659m,
    NullableValue = 0.20278360359375m,
},
    NullableValue = 0.850997199903093m,
},
            new Decimalnumeric0M
{
    Id = 59,
    Value = 0.470725993267947m,
    ModelInner = null,
    NullableValue = 0.424309129100723m,
},
            new Decimalnumeric0M
{
    Id = 61,
    Value = 0.768148609462814m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 24,
    Value = 0.605935491019887m,
    NullableValue = 0.4250038482628m,
},
    NullableValue = 0.791870869802231m,
},
            new Decimalnumeric0M
{
    Id = 62,
    Value = 0.755548462565124m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 66,
    Value = 0.346701533452889m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 31,
    Value = 0.67447767914428m,
    NullableValue = 0.454776125078446m,
},
    NullableValue = 0.18766913199788m,
},
            new Decimalnumeric0M
{
    Id = 73,
    Value = 0.325377268645279m,
    ModelInner = null,
    NullableValue = 0.120155966652975m,
},
            new Decimalnumeric0M
{
    Id = 79,
    Value = 0.26062914982047m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 38,
    Value = 0.01324303573678m,
    NullableValue = 0.966763882764877m,
},
    NullableValue = 0.94682903700728m,
},
            new Decimalnumeric0M
{
    Id = 81,
    Value = 0.729959122608671m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 87,
    Value = 0.123129188816288m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 41,
    Value = 0.152218599142568m,
    NullableValue = null,
},
    NullableValue = 0.393038233440739m,
},
            new Decimalnumeric0M
{
    Id = 88,
    Value = 0.990861193001489m,
    ModelInner = null,
    NullableValue = 0.0185811788933756m,
},
            new Decimalnumeric0M
{
    Id = 95,
    Value = 0.305177632059609m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 42,
    Value = 0.907644464473696m,
    NullableValue = 0.692864986002671m,
},
    NullableValue = 0.0232631164311394m,
},
            new Decimalnumeric0M
{
    Id = 98,
    Value = 0.418115051462009m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 100,
    Value = 0.673728179649533m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 51,
    Value = 0.090053476208599m,
    NullableValue = 0.0937059398174863m,
},
    NullableValue = 0.451785842884496m,
},
            new Decimalnumeric0M
{
    Id = 101,
    Value = 0.678929903620754m,
    ModelInner = null,
    NullableValue = 0.878205630258368m,
},
            new Decimalnumeric0M
{
    Id = 104,
    Value = 0.00549037768475147m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 52,
    Value = 0.397295769592668m,
    NullableValue = 0.147995903868795m,
},
    NullableValue = 0.670011368362125m,
},
            new Decimalnumeric0M
{
    Id = 112,
    Value = 0.06473025704523m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 119,
    Value = 0.595525300944139m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 53,
    Value = 0.338520869004604m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 124,
    Value = 0.145988172331609m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimalnumeric0M
{
    Id = 130,
    Value = 0.611441222821704m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 62,
    Value = 0.500763534380118m,
    NullableValue = null,
},
    NullableValue = 0.599017505699084m,
},
            new Decimalnumeric0M
{
    Id = 131,
    Value = 0.578281040734532m,
    ModelInner = null,
    NullableValue = 0.936285585906764m,
},
            new Decimalnumeric0M
{
    Id = 138,
    Value = 0.995592231929168m,
    ModelInner = new Decimalnumeric0MI
{
    Id = 67,
    Value = 0.282124398383911m,
    NullableValue = 0.558582095477699m,
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.373306394703574m));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.590842449980694m));
                nullable =  ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.850997199903093m));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.424309129100723m));
                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.791870869802231m));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimalnumeric0M.AssertModel(models[0],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Decimalnumeric0M.AssertModel(models[0],_testData[11], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Decimalnumeric0M.AssertModel(models[0],_testData[8], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[9], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[10], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[11], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[19],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[20],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Decimalnumeric0M.AssertModel(models[0],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[28],_testData[29], false);
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
                await ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 95, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumeric0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 104, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[29], false);
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
                 ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 59, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[29], false);
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
                await ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[27],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumeric0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumeric0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumeric0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumeric0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumeric0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumeric0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumeric0M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(models[3],_testData[29], false);
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
                 ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumeric0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumeric0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumeric0M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 100, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Decimalnumeric0M.AssertModel(models[0],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Decimalnumeric0M.AssertModel(models[0],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 124, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimalnumeric0M.AssertModel(models[0],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Decimalnumeric0M.AssertModel(models[0],_testData[9], false);
                        Decimalnumeric0M.AssertModel(models[1],_testData[10], false);
                        Decimalnumeric0M.AssertModel(models[2],_testData[11], false);
                        Decimalnumeric0M.AssertModel(models[3],_testData[12], false);
                        Decimalnumeric0M.AssertModel(models[4],_testData[13], false);
                        Decimalnumeric0M.AssertModel(models[5],_testData[14], false);
                        Decimalnumeric0M.AssertModel(models[6],_testData[15], false);
                        Decimalnumeric0M.AssertModel(models[7],_testData[16], false);
                        Decimalnumeric0M.AssertModel(models[8],_testData[17], false);
                        Decimalnumeric0M.AssertModel(models[9],_testData[18], false);
                        Decimalnumeric0M.AssertModel(models[10],_testData[19], false);
                        Decimalnumeric0M.AssertModel(models[11],_testData[20], false);
                        Decimalnumeric0M.AssertModel(models[12],_testData[21], false);
                        Decimalnumeric0M.AssertModel(models[13],_testData[22], false);
                        Decimalnumeric0M.AssertModel(models[14],_testData[23], false);
                        Decimalnumeric0M.AssertModel(models[15],_testData[24], false);
                        Decimalnumeric0M.AssertModel(models[16],_testData[25], false);
                        Decimalnumeric0M.AssertModel(models[17],_testData[26], false);
                        Decimalnumeric0M.AssertModel(models[18],_testData[27], false);
                        Decimalnumeric0M.AssertModel(models[19],_testData[28], false);
                        Decimalnumeric0M.AssertModel(models[20],_testData[29], false);
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
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Decimalnumeric0M.AssertModel(models[0],_testData[5], false);Decimalnumeric0M.AssertModel(models[1],_testData[6], false);Decimalnumeric0M.AssertModel(models[2],_testData[7], false);Decimalnumeric0M.AssertModel(models[3],_testData[8], false);Decimalnumeric0M.AssertModel(models[4],_testData[9], false);Decimalnumeric0M.AssertModel(models[5],_testData[10], false);Decimalnumeric0M.AssertModel(models[6],_testData[11], false);Decimalnumeric0M.AssertModel(models[7],_testData[12], false);Decimalnumeric0M.AssertModel(models[8],_testData[13], false);Decimalnumeric0M.AssertModel(models[9],_testData[14], false);Decimalnumeric0M.AssertModel(models[10],_testData[15], false);Decimalnumeric0M.AssertModel(models[11],_testData[16], false);Decimalnumeric0M.AssertModel(models[12],_testData[17], false);Decimalnumeric0M.AssertModel(models[13],_testData[18], false);Decimalnumeric0M.AssertModel(models[14],_testData[19], false);Decimalnumeric0M.AssertModel(models[15],_testData[20], false);Decimalnumeric0M.AssertModel(models[16],_testData[21], false);Decimalnumeric0M.AssertModel(models[17],_testData[22], false);Decimalnumeric0M.AssertModel(models[18],_testData[23], false);Decimalnumeric0M.AssertModel(models[19],_testData[24], false);Decimalnumeric0M.AssertModel(models[20],_testData[25], false);Decimalnumeric0M.AssertModel(models[21],_testData[26], false);Decimalnumeric0M.AssertModel(models[22],_testData[27], false);Decimalnumeric0M.AssertModel(models[23],_testData[28], false);Decimalnumeric0M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Decimalnumeric0M.AssertModel(models[0],_testData[19], false);Decimalnumeric0M.AssertModel(models[1],_testData[20], false);Decimalnumeric0M.AssertModel(models[2],_testData[21], false);Decimalnumeric0M.AssertModel(models[3],_testData[22], false);Decimalnumeric0M.AssertModel(models[4],_testData[23], false);Decimalnumeric0M.AssertModel(models[5],_testData[24], false);Decimalnumeric0M.AssertModel(models[6],_testData[25], false);Decimalnumeric0M.AssertModel(models[7],_testData[26], false);Decimalnumeric0M.AssertModel(models[8],_testData[27], false);Decimalnumeric0M.AssertModel(models[9],_testData[28], false);Decimalnumeric0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0457280939832466m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.88793570483551m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.901092417432652m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.485917021818525m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.3173030435495m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.545326702119133m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.151741956244085m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126226885077491m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.900123437433812m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.928026296590762m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.373306394703574m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.698415189456558m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0451391990202364m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0645728305935538m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.274770600740436m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.898393030599832m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.590842449980694m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.16156368627936m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.430598575494659m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.20278360359375m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.850997199903093m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.470725993267947m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.424309129100723m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.768148609462814m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.605935491019887m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.4250038482628m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.791870869802231m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.755548462565124m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.346701533452889m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.67447767914428m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.454776125078446m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.18766913199788m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.325377268645279m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.120155966652975m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.26062914982047m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.01324303573678m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.966763882764877m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.94682903700728m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.729959122608671m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.123129188816288m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.152218599142568m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.393038233440739m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.990861193001489m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0185811788933756m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.305177632059609m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.907644464473696m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.692864986002671m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0232631164311394m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.418115051462009m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673728179649533m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.090053476208599m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0937059398174863m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.451785842884496m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.678929903620754m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.878205630258368m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00549037768475147m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.397295769592668m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.147995903868795m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.670011368362125m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.06473025704523m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.595525300944139m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.338520869004604m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.145988172331609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.611441222821704m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.500763534380118m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.599017505699084m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.578281040734532m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.936285585906764m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.995592231929168m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.282124398383911m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.558582095477699m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0457280939832466m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.88793570483551m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.901092417432652m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.485917021818525m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.3173030435495m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.545326702119133m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.151741956244085m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.126226885077491m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.900123437433812m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.928026296590762m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.373306394703574m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.698415189456558m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0451391990202364m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0645728305935538m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.274770600740436m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.898393030599832m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.590842449980694m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.16156368627936m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.430598575494659m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.20278360359375m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.850997199903093m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.470725993267947m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.424309129100723m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.768148609462814m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.605935491019887m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.4250038482628m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.791870869802231m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.755548462565124m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.346701533452889m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.67447767914428m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.454776125078446m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.18766913199788m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.325377268645279m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.120155966652975m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.26062914982047m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.01324303573678m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.966763882764877m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.94682903700728m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.729959122608671m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.123129188816288m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.152218599142568m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.393038233440739m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.990861193001489m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0185811788933756m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.305177632059609m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.907644464473696m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.692864986002671m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0232631164311394m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.418115051462009m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673728179649533m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.090053476208599m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0937059398174863m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.451785842884496m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.678929903620754m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.878205630258368m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00549037768475147m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.397295769592668m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.147995903868795m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.670011368362125m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.06473025704523m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.595525300944139m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.338520869004604m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.145988172331609m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.611441222821704m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.500763534380118m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.599017505699084m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.578281040734532m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.936285585906764m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.995592231929168m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.282124398383911m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.558582095477699m)));//InnerModel.NullableValue

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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
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
            queryMapTypes: [typeof(Decimalnumeric0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypenumeric))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Decimalnumeric0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IDecimalSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Decimalnumeric0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IDecimalSingleTypenumeric)this).ImportModel(connection, importCollection);
                var models = ((IDecimalSingleTypenumeric)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Decimalnumeric0M.AssertModel(models[0],_testData[0], false);
                Decimalnumeric0M.AssertModel(models[1],_testData[1], false);
                Decimalnumeric0M.AssertModel(models[2],_testData[2], false);
                Decimalnumeric0M.AssertModel(models[3],_testData[3], false);
                Decimalnumeric0M.AssertModel(models[4],_testData[4], false);
                Decimalnumeric0M.AssertModel(models[5],_testData[5], false);
                Decimalnumeric0M.AssertModel(models[6],_testData[6], false);
                Decimalnumeric0M.AssertModel(models[7],_testData[7], false);
                Decimalnumeric0M.AssertModel(models[8],_testData[8], false);
                Decimalnumeric0M.AssertModel(models[9],_testData[9], false);
                Decimalnumeric0M.AssertModel(models[10],_testData[10], false);
                Decimalnumeric0M.AssertModel(models[11],_testData[11], false);
                Decimalnumeric0M.AssertModel(models[12],_testData[12], false);
                Decimalnumeric0M.AssertModel(models[13],_testData[13], false);
                Decimalnumeric0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IDecimalSingleTypenumeric)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalSingleTypenumeric)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Decimalnumeric0M.AssertModel(models[0],_testData[0], false);
                Decimalnumeric0M.AssertModel(models[1],_testData[1], false);
                Decimalnumeric0M.AssertModel(models[2],_testData[2], false);
                Decimalnumeric0M.AssertModel(models[3],_testData[3], false);
                Decimalnumeric0M.AssertModel(models[4],_testData[4], false);
                Decimalnumeric0M.AssertModel(models[5],_testData[5], false);
                Decimalnumeric0M.AssertModel(models[6],_testData[6], false);
                Decimalnumeric0M.AssertModel(models[7],_testData[7], false);
                Decimalnumeric0M.AssertModel(models[8],_testData[8], false);
                Decimalnumeric0M.AssertModel(models[9],_testData[9], false);
                Decimalnumeric0M.AssertModel(models[10],_testData[10], false);
                Decimalnumeric0M.AssertModel(models[11],_testData[11], false);
                Decimalnumeric0M.AssertModel(models[12],_testData[12], false);
                Decimalnumeric0M.AssertModel(models[13],_testData[13], false);
                Decimalnumeric0M.AssertModel(models[14],_testData[14], false);
                Decimalnumeric0M.AssertModel(models[15],_testData[15], false);
                Decimalnumeric0M.AssertModel(models[16],_testData[16], false);
                Decimalnumeric0M.AssertModel(models[17],_testData[17], false);
                Decimalnumeric0M.AssertModel(models[18],_testData[18], false);
                Decimalnumeric0M.AssertModel(models[19],_testData[19], false);
                Decimalnumeric0M.AssertModel(models[20],_testData[20], false);
                Decimalnumeric0M.AssertModel(models[21],_testData[21], false);
                Decimalnumeric0M.AssertModel(models[22],_testData[22], false);
                Decimalnumeric0M.AssertModel(models[23],_testData[23], false);
                Decimalnumeric0M.AssertModel(models[24],_testData[24], false);
                Decimalnumeric0M.AssertModel(models[25],_testData[25], false);
                Decimalnumeric0M.AssertModel(models[26],_testData[26], false);
                Decimalnumeric0M.AssertModel(models[27],_testData[27], false);
                Decimalnumeric0M.AssertModel(models[28],_testData[28], false);
                Decimalnumeric0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_decimalnumeric0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Decimalnumeric0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypenumeric)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypenumeric)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Decimalnumeric0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

