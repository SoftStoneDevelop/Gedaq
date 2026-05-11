

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

        private readonly DecimalnumericE0M[] _testData = new DecimalnumericE0M[]
        {
            new DecimalnumericE0M
{
    Id = 9,
    Value = 0.189325384336638m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 10,
    Value = 0.384880443229396m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 9,
    Value = 0.998823957667754m,
    NullableValue = 0.567938284827693m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 14,
    Value = 0.129213379410243m,
    ModelInner = null,
    NullableValue = 0.190714407699673m,
},
            new DecimalnumericE0M
{
    Id = 16,
    Value = 0.290791984201141m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 16,
    Value = 0.311715369476052m,
    NullableValue = null,
},
    NullableValue = 0.100691477800675m,
},
            new DecimalnumericE0M
{
    Id = 20,
    Value = 0.28575296318575m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 22,
    Value = 0.686607496077995m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 20,
    Value = 0.0105560781117664m,
    NullableValue = 0.481289357087931m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 26,
    Value = 0.739866305837399m,
    ModelInner = null,
    NullableValue = 0.28888001497857m,
},
            new DecimalnumericE0M
{
    Id = 30,
    Value = 0.713845477342862m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 26,
    Value = 0.169762427229073m,
    NullableValue = 0.645685409217843m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 35,
    Value = 0.654130365297786m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 40,
    Value = 0.0874707958372247m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 32,
    Value = 0.695435333261338m,
    NullableValue = 0.203340336547591m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 47,
    Value = 0.659817001068765m,
    ModelInner = null,
    NullableValue = 0.353854367818212m,
},
            new DecimalnumericE0M
{
    Id = 51,
    Value = 0.888730130758763m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 33,
    Value = 0.810547902146906m,
    NullableValue = null,
},
    NullableValue = 0.0176490442082643m,
},
            new DecimalnumericE0M
{
    Id = 55,
    Value = 0.00533602626599927m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 57,
    Value = 0.640738632966322m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 40,
    Value = 0.562494887278031m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 61,
    Value = 0.00302653292493571m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 66,
    Value = 0.65787975362186m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 49,
    Value = 0.31845761809393m,
    NullableValue = null,
},
    NullableValue = 0.763271109320216m,
},
            new DecimalnumericE0M
{
    Id = 73,
    Value = 0.948392819632321m,
    ModelInner = null,
    NullableValue = 0.974973069308582m,
},
            new DecimalnumericE0M
{
    Id = 76,
    Value = 0.454443740850229m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 52,
    Value = 0.584344428883437m,
    NullableValue = 0.94378181266206m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 81,
    Value = 0.00426663479180567m,
    ModelInner = null,
    NullableValue = 0.634136156141981m,
},
            new DecimalnumericE0M
{
    Id = 90,
    Value = 0.981519783294157m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 56,
    Value = 0.693266327800089m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 91,
    Value = 0.0953599005402932m,
    ModelInner = null,
    NullableValue = 0.53473797732304m,
},
            new DecimalnumericE0M
{
    Id = 98,
    Value = 0.0274665148729757m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 62,
    Value = 0.0675956335635908m,
    NullableValue = 0.214675054249564m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 103,
    Value = 0.650569625029909m,
    ModelInner = null,
    NullableValue = 0.939754285507804m,
},
            new DecimalnumericE0M
{
    Id = 112,
    Value = 0.989311141512239m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 67,
    Value = 0.15409144884225m,
    NullableValue = 0.131007687537248m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 120,
    Value = 0.00578007658652291m,
    ModelInner = null,
    NullableValue = 0.466039110816211m,
},
            new DecimalnumericE0M
{
    Id = 126,
    Value = 0.345513268615401m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 71,
    Value = 0.797102404830222m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 129,
    Value = 0.399198994499163m,
    ModelInner = null,
    NullableValue = 0.941291241212094m,
},
            new DecimalnumericE0M
{
    Id = 133,
    Value = 0.500539226003824m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 75,
    Value = 0.650001918969562m,
    NullableValue = null,
},
    NullableValue = 0.42797699071095m,
},
            new DecimalnumericE0M
{
    Id = 139,
    Value = 0.735183055426517m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 143,
    Value = 0.724338057224445m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 80,
    Value = 0.397607594202376m,
    NullableValue = 0.115381049380622m,
},
    NullableValue = 0.163900441960582m,
},
            new DecimalnumericE0M
{
    Id = 145,
    Value = 0.386688871127022m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 154,
    Value = 0.55355058694298m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 83,
    Value = 0.714875242336496m,
    NullableValue = 0.163040722897178m,
},
    NullableValue = 0.733277259364605m,
},
            new DecimalnumericE0M
{
    Id = 161,
    Value = 0.697308587402913m,
    ModelInner = null,
    NullableValue = 0.00875463711434621m,
},
            new DecimalnumericE0M
{
    Id = 165,
    Value = 0.966649348190672m,
    ModelInner = new DecimalnumericE0MI
{
    Id = 85,
    Value = 0.594090852642496m,
    NullableValue = 0.535404252899251m,
},
    NullableValue = null,
},
            new DecimalnumericE0M
{
    Id = 166,
    Value = 0.790511004328127m,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumerice0mi(
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
INSERT INTO public.decimalnumerice0mi(
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
            queryMapTypes: [typeof(DecimalnumericE0MI)],
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
INSERT INTO public.decimalnumerice0mi(
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
INSERT INTO public.decimalnumerice0m(
	id,
    value,
    nullablevalue,
    decimalnumerice0mi_id
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
                methodParametrName: "decimalnumerice0mi_id", 
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
INSERT INTO public.decimalnumerice0m(
	id,
    value,
    nullablevalue,
    decimalnumerice0mi_id
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
    decimalnumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                Assert.That(nullable, Is.EqualTo(0.28888001497857m));
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
INSERT INTO public.decimalnumerice0m(
	id,
    value,
    nullablevalue,
    decimalnumerice0mi_id
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
    decimalnumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                methodParametrName: "decimalnumerice0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.353854367818212m));
                nullable = await ((IDecimalSingleTypenumeric)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.0176490442082643m));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericE0M> models = null;

                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalSingleTypenumeric)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericE0M> models = null;

                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumerice0m(
	id,
    value,
    nullablevalue,
    decimalnumerice0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimalnumerice0mi_id
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
                parametrName: "decimalnumerice0mi_id", 
                methodParametrName: "decimalnumerice0mi_id", 
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
            queryMapTypes: [typeof(FlatDecimalnumericE0M), typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
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
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
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
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
LEFT JOIN public.decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericE0M), typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                ((IDecimalSingleTypenumeric)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
LEFT JOIN public.decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericE0M), typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                await((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
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
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 26;
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumerice0m m
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
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumerice0m m
LEFT JOIN public.decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericE0M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericE0M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericE0M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericE0M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericE0M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericE0M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericE0M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericE0M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericE0M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericE0M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericE0M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericE0M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericE0M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericE0M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericE0M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericE0M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericE0M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericE0M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[10],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[11],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[12],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[13],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[14],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[15],_testData[34], false);
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericE0M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericE0M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericE0M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericE0M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericE0M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericE0M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericE0M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericE0M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericE0M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericE0M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericE0M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericE0M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericE0M), typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                await((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericE0M>();
                var models2 = new List<FlatDecimalnumericE0M>();
                ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var firstItems2 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericE0M)],
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 90, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                await ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 57, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericE0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericE0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericE0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericE0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(models[30],_testData[34], false);
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
FROM public.decimalnumerice0m m
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
FROM public.decimalnumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems1 = new List<FlatDecimalnumericE0M>();
                var secondItems2 = new List<FlatDecimalnumericE0M>();
                 ((IDecimalSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 161, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.decimalnumerice0m m
LEFT JOIN public.decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericE0M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericE0M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[34], false);
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
                    DecimalnumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 66, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericE0M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericE0M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericE0M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericE0M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericE0M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[13],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[14],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[15],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[16],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[17],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericE0M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericE0M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericE0M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericE0M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericE0M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericE0M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericE0M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericE0M.AssertModel(models[7],_testData[34], false);
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
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                DecimalnumericE0M.AssertModel(models[0],_testData[25], false);
                DecimalnumericE0M.AssertModel(models[1],_testData[26], false);
                DecimalnumericE0M.AssertModel(models[2],_testData[27], false);
                DecimalnumericE0M.AssertModel(models[3],_testData[28], false);
                DecimalnumericE0M.AssertModel(models[4],_testData[29], false);
                DecimalnumericE0M.AssertModel(models[5],_testData[30], false);
                DecimalnumericE0M.AssertModel(models[6],_testData[31], false);
                DecimalnumericE0M.AssertModel(models[7],_testData[32], false);
                DecimalnumericE0M.AssertModel(models[8],_testData[33], false);
                DecimalnumericE0M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((IDecimalSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                DecimalnumericE0M.AssertModel(models[0],_testData[6], false);
                DecimalnumericE0M.AssertModel(models[1],_testData[7], false);
                DecimalnumericE0M.AssertModel(models[2],_testData[8], false);
                DecimalnumericE0M.AssertModel(models[3],_testData[9], false);
                DecimalnumericE0M.AssertModel(models[4],_testData[10], false);
                DecimalnumericE0M.AssertModel(models[5],_testData[11], false);
                DecimalnumericE0M.AssertModel(models[6],_testData[12], false);
                DecimalnumericE0M.AssertModel(models[7],_testData[13], false);
                DecimalnumericE0M.AssertModel(models[8],_testData[14], false);
                DecimalnumericE0M.AssertModel(models[9],_testData[15], false);
                DecimalnumericE0M.AssertModel(models[10],_testData[16], false);
                DecimalnumericE0M.AssertModel(models[11],_testData[17], false);
                DecimalnumericE0M.AssertModel(models[12],_testData[18], false);
                DecimalnumericE0M.AssertModel(models[13],_testData[19], false);
                DecimalnumericE0M.AssertModel(models[14],_testData[20], false);
                DecimalnumericE0M.AssertModel(models[15],_testData[21], false);
                DecimalnumericE0M.AssertModel(models[16],_testData[22], false);
                DecimalnumericE0M.AssertModel(models[17],_testData[23], false);
                DecimalnumericE0M.AssertModel(models[18],_testData[24], false);
                DecimalnumericE0M.AssertModel(models[19],_testData[25], false);
                DecimalnumericE0M.AssertModel(models[20],_testData[26], false);
                DecimalnumericE0M.AssertModel(models[21],_testData[27], false);
                DecimalnumericE0M.AssertModel(models[22],_testData[28], false);
                DecimalnumericE0M.AssertModel(models[23],_testData[29], false);
                DecimalnumericE0M.AssertModel(models[24],_testData[30], false);
                DecimalnumericE0M.AssertModel(models[25],_testData[31], false);
                DecimalnumericE0M.AssertModel(models[26],_testData[32], false);
                DecimalnumericE0M.AssertModel(models[27],_testData[33], false);
                DecimalnumericE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.decimalnumerice0m m
LEFT JOIN public.decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
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
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.189325384336638m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.384880443229396m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.998823957667754m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.567938284827693m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.129213379410243m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.190714407699673m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.290791984201141m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.311715369476052m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100691477800675m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.28575296318575m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.686607496077995m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0105560781117664m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.481289357087931m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.739866305837399m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.28888001497857m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.713845477342862m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.169762427229073m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.645685409217843m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.654130365297786m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0874707958372247m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.695435333261338m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.203340336547591m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.659817001068765m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.353854367818212m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.888730130758763m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.810547902146906m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0176490442082643m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00533602626599927m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640738632966322m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.562494887278031m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00302653292493571m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.65787975362186m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.31845761809393m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.763271109320216m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.948392819632321m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.974973069308582m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.454443740850229m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.584344428883437m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.94378181266206m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00426663479180567m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.634136156141981m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.981519783294157m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.693266327800089m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0953599005402932m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.53473797732304m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0274665148729757m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0675956335635908m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.214675054249564m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.650569625029909m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.939754285507804m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989311141512239m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.15409144884225m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.131007687537248m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00578007658652291m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.466039110816211m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.345513268615401m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.797102404830222m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.399198994499163m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.941291241212094m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.500539226003824m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.650001918969562m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.42797699071095m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.735183055426517m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.724338057224445m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.397607594202376m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.115381049380622m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.163900441960582m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.386688871127022m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.55355058694298m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.714875242336496m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.163040722897178m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.733277259364605m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.697308587402913m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00875463711434621m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.966649348190672m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.594090852642496m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.535404252899251m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.790511004328127m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.189325384336638m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.384880443229396m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.998823957667754m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.567938284827693m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.129213379410243m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.190714407699673m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.290791984201141m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.311715369476052m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100691477800675m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.28575296318575m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.686607496077995m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0105560781117664m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.481289357087931m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.739866305837399m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.28888001497857m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.713845477342862m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.169762427229073m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.645685409217843m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.654130365297786m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0874707958372247m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.695435333261338m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.203340336547591m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.659817001068765m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.353854367818212m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.888730130758763m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.810547902146906m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0176490442082643m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00533602626599927m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.640738632966322m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.562494887278031m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00302653292493571m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.65787975362186m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.31845761809393m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.763271109320216m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.948392819632321m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.974973069308582m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.454443740850229m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.584344428883437m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.94378181266206m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00426663479180567m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.634136156141981m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.981519783294157m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.693266327800089m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0953599005402932m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.53473797732304m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0274665148729757m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0675956335635908m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.214675054249564m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.650569625029909m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.939754285507804m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989311141512239m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.15409144884225m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.131007687537248m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00578007658652291m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.466039110816211m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.345513268615401m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.797102404830222m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.399198994499163m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.941291241212094m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.500539226003824m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.650001918969562m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.42797699071095m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.735183055426517m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.724338057224445m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.397607594202376m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.115381049380622m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.163900441960582m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.386688871127022m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.55355058694298m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.714875242336496m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.163040722897178m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.733277259364605m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.697308587402913m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00875463711434621m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.966649348190672m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.594090852642496m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.535404252899251m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.790511004328127m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_decimalnumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
            queryMapType: typeof(DecimalnumericE0MIWA),
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypenumeric)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypenumeric)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
            queryMapType: typeof(DecimalnumericE0MIWA),
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypenumeric)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypenumeric)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MI)],
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
COPY public.binary_decimalnumerice0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericE0MI),
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
                var importCollection = new List<DecimalnumericE0MI>(2);
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
                    DecimalnumericE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericE0MI>(2);
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
                    DecimalnumericE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
COPY public.binary_decimalnumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericE0MIWA),
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericE0MIWA
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
                    DecimalnumericE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumerice0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumerice0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericE0M),
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
FROM public.binary_decimalnumerice0m m
LEFT JOIN public.binary_decimalnumerice0mi mi ON mi.id = m.decimalnumerice0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                var importCollection = new List<DecimalnumericE0M>();
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
                    DecimalnumericE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericE0M>();
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
                    DecimalnumericE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumerice0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumerice0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericE0M)],
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
                    DecimalnumericE0M.AssertModel(model, expectedModel, true);
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
                    DecimalnumericE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA), typeof(DecimalnumericE0MIWA)],
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA), typeof(DecimalnumericE0MIWA)],
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_decimalnumerice0mi
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MI), typeof(DecimalnumericE0MI)],
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
                var models1 = new List<DecimalnumericE0MI>();
                var models2 = new List<DecimalnumericE0MI>();
                await ((IDecimalSingleTypenumeric)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericE0MI>();
                var models2 = new List<DecimalnumericE0MI>();
                ((IDecimalSingleTypenumeric)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumerice0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MI)],
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
                    DecimalnumericE0MI.AssertModel(model, expectedModel, false);
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
                    DecimalnumericE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA), typeof(DecimalnumericE0MIWA)],
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
                await ((IDecimalSingleTypenumeric)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericE0MIWA>();
                var models2 = new List<DecimalnumericE0MIWA>();
                ((IDecimalSingleTypenumeric)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumerice0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericE0MIWA)],
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
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
                    DecimalnumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

