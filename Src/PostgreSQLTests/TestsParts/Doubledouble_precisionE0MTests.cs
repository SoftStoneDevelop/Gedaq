

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

        private readonly Doubledouble_precisionE0M[] _testData = new Doubledouble_precisionE0M[]
        {
            new Doubledouble_precisionE0M
{
    Id = 1,
    Value = 0.7546410573629634d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 9,
    Value = 0.40622294872243125d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 6,
    Value = 0.7412879554626581d,
    NullableValue = null,
},
    NullableValue = 0.42390427560637245d,
},
            new Doubledouble_precisionE0M
{
    Id = 13,
    Value = 0.2890601626660485d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 14,
    Value = 0.9337761658322354d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 14,
    Value = 0.9106554909013255d,
    NullableValue = null,
},
    NullableValue = 0.43626901684982944d,
},
            new Doubledouble_precisionE0M
{
    Id = 16,
    Value = 0.2827762404214529d,
    ModelInner = null,
    NullableValue = 0.3822743041546304d,
},
            new Doubledouble_precisionE0M
{
    Id = 25,
    Value = 0.9326117881460173d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 20,
    Value = 0.09154914306210271d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 30,
    Value = 0.9335291777250553d,
    ModelInner = null,
    NullableValue = 0.48068813959891254d,
},
            new Doubledouble_precisionE0M
{
    Id = 39,
    Value = 0.03543160440188353d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 28,
    Value = 0.6807848742873086d,
    NullableValue = 0.7463089711829957d,
},
    NullableValue = 0.8512284634174537d,
},
            new Doubledouble_precisionE0M
{
    Id = 45,
    Value = 0.19422631671965418d,
    ModelInner = null,
    NullableValue = 0.026425941194658797d,
},
            new Doubledouble_precisionE0M
{
    Id = 52,
    Value = 0.773278632884625d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 37,
    Value = 0.2316614596549198d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 54,
    Value = 0.25928259174915236d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 57,
    Value = 0.077602581089534d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 38,
    Value = 0.12367013454679554d,
    NullableValue = 0.8175352732521005d,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 63,
    Value = 0.52846877887869d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 66,
    Value = 0.40260624748773555d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 44,
    Value = 0.23324070075874315d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 72,
    Value = 0.20977921489824936d,
    ModelInner = null,
    NullableValue = 0.9978828917083366d,
},
            new Doubledouble_precisionE0M
{
    Id = 80,
    Value = 0.7250266288302786d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 50,
    Value = 0.2268012856977758d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 88,
    Value = 0.6810903297000586d,
    ModelInner = null,
    NullableValue = 0.8302754443794547d,
},
            new Doubledouble_precisionE0M
{
    Id = 92,
    Value = 0.4191878220469508d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 56,
    Value = 0.3171206343230798d,
    NullableValue = 0.6294152298220456d,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 96,
    Value = 0.9134903494278935d,
    ModelInner = null,
    NullableValue = 0.40029946947591954d,
},
            new Doubledouble_precisionE0M
{
    Id = 103,
    Value = 0.39201806589167976d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 59,
    Value = 0.3732984841853194d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 107,
    Value = 0.9083234151194596d,
    ModelInner = null,
    NullableValue = 0.18645294457105666d,
},
            new Doubledouble_precisionE0M
{
    Id = 112,
    Value = 0.4237465314674682d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 64,
    Value = 0.9738187397918567d,
    NullableValue = 0.12140019108752342d,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 120,
    Value = 0.9595773697037274d,
    ModelInner = null,
    NullableValue = 0.3472132272026276d,
},
            new Doubledouble_precisionE0M
{
    Id = 125,
    Value = 0.07027450323719464d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 72,
    Value = 0.33549840487426974d,
    NullableValue = null,
},
    NullableValue = 0.2780110261138492d,
},
            new Doubledouble_precisionE0M
{
    Id = 129,
    Value = 0.7872385413069914d,
    ModelInner = null,
    NullableValue = 0.6206475576960605d,
},
            new Doubledouble_precisionE0M
{
    Id = 135,
    Value = 0.7854893147798228d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 74,
    Value = 0.044925507142739574d,
    NullableValue = null,
},
    NullableValue = 0.16013898560770745d,
},
            new Doubledouble_precisionE0M
{
    Id = 141,
    Value = 0.22227684552954163d,
    ModelInner = null,
    NullableValue = 0.5923134040462841d,
},
            new Doubledouble_precisionE0M
{
    Id = 146,
    Value = 0.14686521400523755d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 75,
    Value = 0.2440391545674082d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 151,
    Value = 0.012163587994770686d,
    ModelInner = null,
    NullableValue = 0.4825028588097705d,
},
            new Doubledouble_precisionE0M
{
    Id = 158,
    Value = 0.3343742697001011d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 82,
    Value = 0.048067022132323056d,
    NullableValue = 0.04358205626729339d,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 163,
    Value = 0.16240261536249734d,
    ModelInner = null,
    NullableValue = 0.12901947856283202d,
},
            new Doubledouble_precisionE0M
{
    Id = 167,
    Value = 0.6940785603101916d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 84,
    Value = 0.27052113517703147d,
    NullableValue = 0.3958810842825504d,
},
    NullableValue = 0.4972350982839918d,
},
            new Doubledouble_precisionE0M
{
    Id = 173,
    Value = 0.3277140752127252d,
    ModelInner = null,
    NullableValue = 0.4219609410994897d,
},
            new Doubledouble_precisionE0M
{
    Id = 175,
    Value = 0.1643507607843704d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 86,
    Value = 0.8236983804276958d,
    NullableValue = 0.04692521644161174d,
},
    NullableValue = null,
},
            new Doubledouble_precisionE0M
{
    Id = 182,
    Value = 0.9617950298415886d,
    ModelInner = null,
    NullableValue = 0.38489437744360255d,
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
INSERT INTO public.doubledouble_precisione0m(
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
INSERT INTO public.doubledouble_precisione0m(
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
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                Assert.That(nullable, Is.EqualTo(0.3822743041546304d));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(0.48068813959891254d));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.8512284634174537d));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisione0m(
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
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                Assert.That(nullable, Is.EqualTo(0.026425941194658797d));
                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                List<Doubledouble_precisionE0M> models = null;

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionE0M> models = null;

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisione0m(
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
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M), typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
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
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
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
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M), typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M), typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
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
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionE0M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionE0M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionE0M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionE0M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionE0M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionE0M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionE0M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionE0M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionE0M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionE0M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionE0M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionE0M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionE0M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionE0M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[30],_testData[34], false);
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M), typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionE0M>();
                var models2 = new List<FlatDoubledouble_precisionE0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var firstItems2 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionE0M)],
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 72, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[25],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionE0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(models[25],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
FROM public.doubledouble_precisione0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems1 = new List<FlatDoubledouble_precisionE0M>();
                var secondItems2 = new List<FlatDoubledouble_precisionE0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionE0M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionE0M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionE0M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionE0M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionE0M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionE0M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionE0M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionE0M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionE0M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionE0M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionE0M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionE0M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[28],_testData[34], false);
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
                    Doubledouble_precisionE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatch(connection, 135, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionE0M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionE0M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionE0M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionE0M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionE0M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionE0M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionE0M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionE0M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionE0M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionE0M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionE0M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionE0M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionE0M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionE0M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionE0M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionE0M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionE0M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionE0M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionE0M.AssertModel(models[18],_testData[34], false);
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
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models = await ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Doubledouble_precisionE0M.AssertModel(models[0],_testData[12], false);
                Doubledouble_precisionE0M.AssertModel(models[1],_testData[13], false);
                Doubledouble_precisionE0M.AssertModel(models[2],_testData[14], false);
                Doubledouble_precisionE0M.AssertModel(models[3],_testData[15], false);
                Doubledouble_precisionE0M.AssertModel(models[4],_testData[16], false);
                Doubledouble_precisionE0M.AssertModel(models[5],_testData[17], false);
                Doubledouble_precisionE0M.AssertModel(models[6],_testData[18], false);
                Doubledouble_precisionE0M.AssertModel(models[7],_testData[19], false);
                Doubledouble_precisionE0M.AssertModel(models[8],_testData[20], false);
                Doubledouble_precisionE0M.AssertModel(models[9],_testData[21], false);
                Doubledouble_precisionE0M.AssertModel(models[10],_testData[22], false);
                Doubledouble_precisionE0M.AssertModel(models[11],_testData[23], false);
                Doubledouble_precisionE0M.AssertModel(models[12],_testData[24], false);
                Doubledouble_precisionE0M.AssertModel(models[13],_testData[25], false);
                Doubledouble_precisionE0M.AssertModel(models[14],_testData[26], false);
                Doubledouble_precisionE0M.AssertModel(models[15],_testData[27], false);
                Doubledouble_precisionE0M.AssertModel(models[16],_testData[28], false);
                Doubledouble_precisionE0M.AssertModel(models[17],_testData[29], false);
                Doubledouble_precisionE0M.AssertModel(models[18],_testData[30], false);
                Doubledouble_precisionE0M.AssertModel(models[19],_testData[31], false);
                Doubledouble_precisionE0M.AssertModel(models[20],_testData[32], false);
                Doubledouble_precisionE0M.AssertModel(models[21],_testData[33], false);
                Doubledouble_precisionE0M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models =  ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Doubledouble_precisionE0M.AssertModel(models[0],_testData[18], false);
                Doubledouble_precisionE0M.AssertModel(models[1],_testData[19], false);
                Doubledouble_precisionE0M.AssertModel(models[2],_testData[20], false);
                Doubledouble_precisionE0M.AssertModel(models[3],_testData[21], false);
                Doubledouble_precisionE0M.AssertModel(models[4],_testData[22], false);
                Doubledouble_precisionE0M.AssertModel(models[5],_testData[23], false);
                Doubledouble_precisionE0M.AssertModel(models[6],_testData[24], false);
                Doubledouble_precisionE0M.AssertModel(models[7],_testData[25], false);
                Doubledouble_precisionE0M.AssertModel(models[8],_testData[26], false);
                Doubledouble_precisionE0M.AssertModel(models[9],_testData[27], false);
                Doubledouble_precisionE0M.AssertModel(models[10],_testData[28], false);
                Doubledouble_precisionE0M.AssertModel(models[11],_testData[29], false);
                Doubledouble_precisionE0M.AssertModel(models[12],_testData[30], false);
                Doubledouble_precisionE0M.AssertModel(models[13],_testData[31], false);
                Doubledouble_precisionE0M.AssertModel(models[14],_testData[32], false);
                Doubledouble_precisionE0M.AssertModel(models[15],_testData[33], false);
                Doubledouble_precisionE0M.AssertModel(models[16],_testData[34], false);
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
FROM public.doubledouble_precisione0m m
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7546410573629634d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40622294872243125d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7412879554626581d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42390427560637245d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2890601626660485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9337761658322354d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9106554909013255d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.43626901684982944d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2827762404214529d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3822743041546304d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9326117881460173d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09154914306210271d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9335291777250553d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.48068813959891254d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03543160440188353d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6807848742873086d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7463089711829957d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8512284634174537d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19422631671965418d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.026425941194658797d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.773278632884625d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2316614596549198d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.25928259174915236d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.077602581089534d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12367013454679554d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8175352732521005d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.52846877887869d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40260624748773555d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23324070075874315d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20977921489824936d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9978828917083366d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7250266288302786d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2268012856977758d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6810903297000586d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8302754443794547d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4191878220469508d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3171206343230798d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6294152298220456d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9134903494278935d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40029946947591954d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39201806589167976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3732984841853194d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9083234151194596d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18645294457105666d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4237465314674682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9738187397918567d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.12140019108752342d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9595773697037274d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3472132272026276d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07027450323719464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33549840487426974d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2780110261138492d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7872385413069914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6206475576960605d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7854893147798228d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.044925507142739574d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16013898560770745d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.22227684552954163d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5923134040462841d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14686521400523755d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2440391545674082d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012163587994770686d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4825028588097705d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3343742697001011d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.048067022132323056d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04358205626729339d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16240261536249734d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12901947856283202d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6940785603101916d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.27052113517703147d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3958810842825504d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4972350982839918d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3277140752127252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4219609410994897d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1643507607843704d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8236983804276958d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04692521644161174d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9617950298415886d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.38489437744360255d)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7546410573629634d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40622294872243125d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7412879554626581d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.42390427560637245d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2890601626660485d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9337761658322354d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9106554909013255d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.43626901684982944d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2827762404214529d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3822743041546304d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9326117881460173d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09154914306210271d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9335291777250553d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.48068813959891254d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.03543160440188353d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6807848742873086d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7463089711829957d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8512284634174537d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19422631671965418d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.026425941194658797d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.773278632884625d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2316614596549198d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.25928259174915236d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.077602581089534d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.12367013454679554d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8175352732521005d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.52846877887869d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40260624748773555d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23324070075874315d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20977921489824936d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9978828917083366d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7250266288302786d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2268012856977758d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6810903297000586d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8302754443794547d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4191878220469508d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3171206343230798d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6294152298220456d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9134903494278935d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40029946947591954d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39201806589167976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3732984841853194d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9083234151194596d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18645294457105666d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4237465314674682d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9738187397918567d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.12140019108752342d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9595773697037274d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3472132272026276d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.07027450323719464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33549840487426974d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2780110261138492d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7872385413069914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6206475576960605d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7854893147798228d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.044925507142739574d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16013898560770745d)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.22227684552954163d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5923134040462841d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14686521400523755d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2440391545674082d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.012163587994770686d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4825028588097705d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3343742697001011d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.048067022132323056d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04358205626729339d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16240261536249734d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12901947856283202d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6940785603101916d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.27052113517703147d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3958810842825504d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4972350982839918d)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3277140752127252d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4219609410994897d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1643507607843704d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8236983804276958d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.04692521644161174d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9617950298415886d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.38489437744360255d)));

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
COPY public.binary_doubledouble_precisione0m
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
            queryMapType: typeof(Doubledouble_precisionE0M),
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
FROM public.binary_doubledouble_precisione0m m
LEFT JOIN public.binary_doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
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
                var importCollection = new List<Doubledouble_precisionE0M>();
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
                    Doubledouble_precisionE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionE0M>();
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
                    Doubledouble_precisionE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisione0m
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
            queryMapTypes: [typeof(Doubledouble_precisionE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
                var models =  ((IDoubleSingleTypedouble_precision)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionE0M.AssertModel(model, expectedModel, true);
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
                    Doubledouble_precisionE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA), typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precision0mi
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
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precision0mi
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
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA), typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precision0mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleSingleTypedouble_precision)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precision0mi
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
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI), typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
                var models1 = new List<Doubledouble_precision0MI>();
                var models2 = new List<Doubledouble_precision0MI>();
                await ((IDoubleSingleTypedouble_precision)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precision0MI>();
                var models2 = new List<Doubledouble_precision0MI>();
                ((IDoubleSingleTypedouble_precision)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
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
                var models = await ((IDoubleSingleTypedouble_precision)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleSingleTypedouble_precision)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precision0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA), typeof(Doubledouble_precision0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                await ((IDoubleSingleTypedouble_precision)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precision0MIWA>();
                var models2 = new List<Doubledouble_precision0MIWA>();
                ((IDoubleSingleTypedouble_precision)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleSingleTypedouble_precision)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleSingleTypedouble_precision)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

