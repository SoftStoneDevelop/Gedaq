

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
    internal partial interface IDoubleSingleTypedouble_precision
    {
    }
    
    internal partial class DoubleSingleTypedouble_precision : IDoubleSingleTypedouble_precision
    {


#region TestData

        private readonly Doubledouble_precision0M[] _testData = new Doubledouble_precision0M[]
        {
            new Doubledouble_precision0M
{
    Id = 4,
    Value = 0.7538037232027579d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 6,
    Value = 0.1899128529308941d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 3,
    Value = 0.8443664077775592d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 15,
    Value = 0.934994015848205d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 24,
    Value = 0.10437789938370112d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 12,
    Value = 0.5461835381643966d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 28,
    Value = 0.6643707907438768d,
    ModelInner = null,
    NullableValue = 0.3283011364344064d,
},
            new Doubledouble_precision0M
{
    Id = 31,
    Value = 0.49638196141849456d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 18,
    Value = 0.17521996223198677d,
    NullableValue = 0.8184864602253441d,
},
    NullableValue = 0.6608801722354295d,
},
            new Doubledouble_precision0M
{
    Id = 37,
    Value = 0.8006379067708076d,
    ModelInner = null,
    NullableValue = 0.2562148094361071d,
},
            new Doubledouble_precision0M
{
    Id = 41,
    Value = 0.05599144197032424d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 26,
    Value = 0.46531720299599033d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 47,
    Value = 0.7337825573447627d,
    ModelInner = null,
    NullableValue = 0.7864166835580844d,
},
            new Doubledouble_precision0M
{
    Id = 54,
    Value = 0.8720165101124924d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 32,
    Value = 0.06638490883207249d,
    NullableValue = 0.24826998302937808d,
},
    NullableValue = 0.9418069724154389d,
},
            new Doubledouble_precision0M
{
    Id = 59,
    Value = 0.40291244832632134d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 66,
    Value = 0.809065141926961d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 40,
    Value = 0.664121558822018d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 71,
    Value = 0.3274119322125597d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 77,
    Value = 0.07792984009921367d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 43,
    Value = 0.003387659308588531d,
    NullableValue = 0.6035263242149967d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 84,
    Value = 0.28776505271443d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 90,
    Value = 0.281789159523371d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 47,
    Value = 0.4513464572897754d,
    NullableValue = 0.616277430918506d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 91,
    Value = 0.05991900539356143d,
    ModelInner = null,
    NullableValue = 0.5426029323582277d,
},
            new Doubledouble_precision0M
{
    Id = 92,
    Value = 0.044252938571490374d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 54,
    Value = 0.012197308312593691d,
    NullableValue = null,
},
    NullableValue = 0.4146966027794319d,
},
            new Doubledouble_precision0M
{
    Id = 95,
    Value = 0.6482040657578876d,
    ModelInner = null,
    NullableValue = 0.7546253171312426d,
},
            new Doubledouble_precision0M
{
    Id = 102,
    Value = 0.3728003536975595d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 56,
    Value = 0.15804869457367898d,
    NullableValue = null,
},
    NullableValue = 0.95374934625925d,
},
            new Doubledouble_precision0M
{
    Id = 109,
    Value = 0.2191019286076319d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 111,
    Value = 0.012311959753211199d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 59,
    Value = 0.052179044975846356d,
    NullableValue = 0.10042252386354944d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 118,
    Value = 0.6082816253633561d,
    ModelInner = null,
    NullableValue = 0.3638102075281311d,
},
            new Doubledouble_precision0M
{
    Id = 124,
    Value = 0.2772042394566302d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 64,
    Value = 0.8345522967440809d,
    NullableValue = null,
},
    NullableValue = 0.8698562135064444d,
},
            new Doubledouble_precision0M
{
    Id = 130,
    Value = 0.2905655334003423d,
    ModelInner = null,
    NullableValue = 0.21561376812251332d,
},
            new Doubledouble_precision0M
{
    Id = 139,
    Value = 0.9656040595512697d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 72,
    Value = 0.9976773383670325d,
    NullableValue = 0.5289185702472919d,
},
    NullableValue = 0.6272985897903053d,
},
            new Doubledouble_precision0M
{
    Id = 141,
    Value = 0.8852000251247011d,
    ModelInner = null,
    NullableValue = 0.23657635000855814d,
},
            new Doubledouble_precision0M
{
    Id = 148,
    Value = 0.08865952877353844d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 79,
    Value = 0.9206808441430209d,
    NullableValue = null,
},
    NullableValue = 0.14413608635225705d,
},
            new Doubledouble_precision0M
{
    Id = 154,
    Value = 0.1451884114608163d,
    ModelInner = null,
    NullableValue = 0.3430300496885844d,
},
            new Doubledouble_precision0M
{
    Id = 158,
    Value = 0.9696120693038406d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 80,
    Value = 0.48343050384772634d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 159,
    Value = 0.8427652126225147d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 162,
    Value = 0.5934654514408043d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 82,
    Value = 0.3962717861802363d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 168,
    Value = 0.5757660271212472d,
    ModelInner = null,
    NullableValue = 0.8387936736539889d,
},
            new Doubledouble_precision0M
{
    Id = 175,
    Value = 0.1609489005201551d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 90,
    Value = 0.976151493351251d,
    NullableValue = null,
},
    NullableValue = 0.3311712208962053d,
},
            new Doubledouble_precision0M
{
    Id = 179,
    Value = 0.23912596938609687d,
    ModelInner = null,
    NullableValue = 0.7890115995221866d,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8))]
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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
                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                System.Double? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.3283011364344064d));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.6608801722354295d));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.2562148094361071d));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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
                System.Double? nullable = null;
                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.7864166835580844d));
                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.9418069724154389d));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double? nullable = null;
                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precision0M> models = null;

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precision0M> models = null;

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble_precision0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble_precision0mi_id", 
                methodParametrName: "doubledouble_precision0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypedouble_precision)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 37, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 77, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[34], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatch(connection, 84, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[34], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatch(connection, 148, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatch(connection, 124, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precision0M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precision0M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precision0M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precision0M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precision0M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Doubledouble_precision0M.AssertModel(models[0],_testData[18], false);Doubledouble_precision0M.AssertModel(models[1],_testData[19], false);Doubledouble_precision0M.AssertModel(models[2],_testData[20], false);Doubledouble_precision0M.AssertModel(models[3],_testData[21], false);Doubledouble_precision0M.AssertModel(models[4],_testData[22], false);Doubledouble_precision0M.AssertModel(models[5],_testData[23], false);Doubledouble_precision0M.AssertModel(models[6],_testData[24], false);Doubledouble_precision0M.AssertModel(models[7],_testData[25], false);Doubledouble_precision0M.AssertModel(models[8],_testData[26], false);Doubledouble_precision0M.AssertModel(models[9],_testData[27], false);Doubledouble_precision0M.AssertModel(models[10],_testData[28], false);Doubledouble_precision0M.AssertModel(models[11],_testData[29], false);Doubledouble_precision0M.AssertModel(models[12],_testData[30], false);Doubledouble_precision0M.AssertModel(models[13],_testData[31], false);Doubledouble_precision0M.AssertModel(models[14],_testData[32], false);Doubledouble_precision0M.AssertModel(models[15],_testData[33], false);Doubledouble_precision0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models =  ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Doubledouble_precision0M.AssertModel(models[0],_testData[31], false);Doubledouble_precision0M.AssertModel(models[1],_testData[32], false);Doubledouble_precision0M.AssertModel(models[2],_testData[33], false);Doubledouble_precision0M.AssertModel(models[3],_testData[34], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7538037232027579d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1899128529308941d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8443664077775592d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.934994015848205d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10437789938370112d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5461835381643966d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6643707907438768d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3283011364344064d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49638196141849456d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17521996223198677d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8184864602253441d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6608801722354295d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8006379067708076d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2562148094361071d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05599144197032424d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46531720299599033d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7337825573447627d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7864166835580844d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8720165101124924d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06638490883207249d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.24826998302937808d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9418069724154389d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40291244832632134d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.809065141926961d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.664121558822018d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3274119322125597d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07792984009921367d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.003387659308588531d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6035263242149967d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.28776505271443d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.281789159523371d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4513464572897754d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.616277430918506d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05991900539356143d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5426029323582277d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.044252938571490374d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.012197308312593691d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4146966027794319d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6482040657578876d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7546253171312426d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3728003536975595d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.15804869457367898d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.95374934625925d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2191019286076319d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012311959753211199d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.052179044975846356d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10042252386354944d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6082816253633561d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3638102075281311d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2772042394566302d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8345522967440809d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8698562135064444d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2905655334003423d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.21561376812251332d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9656040595512697d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9976773383670325d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5289185702472919d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6272985897903053d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8852000251247011d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23657635000855814d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08865952877353844d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9206808441430209d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.14413608635225705d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1451884114608163d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3430300496885844d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9696120693038406d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.48343050384772634d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8427652126225147d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5934654514408043d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3962717861802363d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5757660271212472d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8387936736539889d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1609489005201551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.976151493351251d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3311712208962053d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23912596938609687d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7890115995221866d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7538037232027579d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1899128529308941d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8443664077775592d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.934994015848205d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10437789938370112d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5461835381643966d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6643707907438768d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3283011364344064d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49638196141849456d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17521996223198677d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8184864602253441d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6608801722354295d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8006379067708076d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2562148094361071d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05599144197032424d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.46531720299599033d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7337825573447627d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7864166835580844d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8720165101124924d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06638490883207249d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.24826998302937808d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9418069724154389d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40291244832632134d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.809065141926961d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.664121558822018d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3274119322125597d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07792984009921367d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.003387659308588531d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6035263242149967d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.28776505271443d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.281789159523371d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4513464572897754d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.616277430918506d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05991900539356143d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5426029323582277d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.044252938571490374d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.012197308312593691d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4146966027794319d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6482040657578876d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7546253171312426d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3728003536975595d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.15804869457367898d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.95374934625925d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2191019286076319d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012311959753211199d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.052179044975846356d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.10042252386354944d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6082816253633561d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3638102075281311d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2772042394566302d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8345522967440809d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8698562135064444d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2905655334003423d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.21561376812251332d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9656040595512697d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9976773383670325d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5289185702472919d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6272985897903053d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8852000251247011d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23657635000855814d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08865952877353844d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9206808441430209d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.14413608635225705d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1451884114608163d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3430300496885844d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9696120693038406d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.48343050384772634d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8427652126225147d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5934654514408043d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3962717861802363d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5757660271212472d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8387936736539889d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1609489005201551d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.976151493351251d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3311712208962053d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23912596938609687d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7890115995221866d)));

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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleSingleTypedouble_precision)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleSingleTypedouble_precision)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleSingleTypedouble_precision)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleSingleTypedouble_precision)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleSingleTypedouble_precision)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precision0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleSingleTypedouble_precision)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleSingleTypedouble_precision)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precision0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleSingleTypedouble_precision)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleSingleTypedouble_precision)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleSingleTypedouble_precision)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precision0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precision0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleSingleTypedouble_precision)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleSingleTypedouble_precision)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precision0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precision0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
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
FROM public.binary_doubledouble_precision0m m
LEFT JOIN public.binary_doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precision0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleSingleTypedouble_precision)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precision0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precision0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleSingleTypedouble_precision)this).ImportModel(connection, importCollection);
                var models = ((IDoubleSingleTypedouble_precision)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precision0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble_precision)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precision0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precision0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleSingleTypedouble_precision)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleSingleTypedouble_precision)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

