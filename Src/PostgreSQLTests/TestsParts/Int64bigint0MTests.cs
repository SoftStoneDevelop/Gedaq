

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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region TestData

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 8,
    Value = 6320177536023134646L,
    ModelInner = null,
    NullableValue = 8182961652293282965L,
},
            new Int64bigint0M
{
    Id = 15,
    Value = 2260341245603816766L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 6919956141001141566L,
    NullableValue = null,
},
    NullableValue = 8189041842432689283L,
},
            new Int64bigint0M
{
    Id = 22,
    Value = 885619918680017247L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 25,
    Value = 6080256549268164562L,
    ModelInner = new Int64bigint0MI
{
    Id = 12,
    Value = 6935231367160177391L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 33,
    Value = 1908382142313681154L,
    ModelInner = null,
    NullableValue = 6567857530072268079L,
},
            new Int64bigint0M
{
    Id = 40,
    Value = 7635153938630418795L,
    ModelInner = new Int64bigint0MI
{
    Id = 19,
    Value = 2026075049265269259L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 46,
    Value = 1963234981372421114L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 52,
    Value = 2903150859676782954L,
    ModelInner = new Int64bigint0MI
{
    Id = 27,
    Value = 5934354963079124650L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 61,
    Value = 856032276856104032L,
    ModelInner = null,
    NullableValue = 3453012791097202233L,
},
            new Int64bigint0M
{
    Id = 62,
    Value = 510236586542681645L,
    ModelInner = new Int64bigint0MI
{
    Id = 29,
    Value = 8939899319610628007L,
    NullableValue = 3654036059215105497L,
},
    NullableValue = 2292766920896876586L,
},
            new Int64bigint0M
{
    Id = 65,
    Value = 6323896510321392674L,
    ModelInner = null,
    NullableValue = 3909672445520646420L,
},
            new Int64bigint0M
{
    Id = 73,
    Value = 7549368032961242334L,
    ModelInner = new Int64bigint0MI
{
    Id = 32,
    Value = 8139766044309136518L,
    NullableValue = null,
},
    NullableValue = 7528223743640677420L,
},
            new Int64bigint0M
{
    Id = 78,
    Value = 7997793702670227201L,
    ModelInner = null,
    NullableValue = 6733532585434789269L,
},
            new Int64bigint0M
{
    Id = 87,
    Value = 8985700612099061903L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 6003787958356996386L,
    NullableValue = 6090400691469335122L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 94,
    Value = 7106502544352726649L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 103,
    Value = 7825900716233069378L,
    ModelInner = new Int64bigint0MI
{
    Id = 48,
    Value = 2765536247150252162L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 104,
    Value = 199774296955969756L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 108,
    Value = 178063161201897312L,
    ModelInner = new Int64bigint0MI
{
    Id = 51,
    Value = 5394405118145873698L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 117,
    Value = 5124268619221783352L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 9048139052795103924L,
    ModelInner = new Int64bigint0MI
{
    Id = 56,
    Value = 8731435116295339237L,
    NullableValue = 4656834645870025348L,
},
    NullableValue = 5141078451286056906L,
},
            new Int64bigint0M
{
    Id = 122,
    Value = 1900397710133036008L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 124,
    Value = 6005207016962624831L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 2046081990408718159L,
    NullableValue = 3133622804421631109L,
},
    NullableValue = 5744194786600901726L,
},
            new Int64bigint0M
{
    Id = 125,
    Value = 3608129241022571854L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 127,
    Value = 2659791078325729452L,
    ModelInner = new Int64bigint0MI
{
    Id = 58,
    Value = 1353278630710346967L,
    NullableValue = 55186773814009392L,
},
    NullableValue = 355026703709934861L,
},
            new Int64bigint0M
{
    Id = 136,
    Value = 4732823843795091961L,
    ModelInner = null,
    NullableValue = 552574029429224279L,
},
            new Int64bigint0M
{
    Id = 140,
    Value = 6089150398820138284L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 4051781517164558853L,
    NullableValue = null,
},
    NullableValue = 3408397999732272290L,
},
            new Int64bigint0M
{
    Id = 148,
    Value = 1703044129603123291L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 155,
    Value = 453332578666117564L,
    ModelInner = new Int64bigint0MI
{
    Id = 69,
    Value = 4378312240024747984L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 158,
    Value = 8282403303646819544L,
    ModelInner = null,
    NullableValue = 4072803244080110487L,
},
            new Int64bigint0M
{
    Id = 159,
    Value = 5874157146664911923L,
    ModelInner = new Int64bigint0MI
{
    Id = 74,
    Value = 2864410354144717667L,
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            queryMapTypes: [typeof(Int64bigint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1))]
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12), 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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
                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
    int64bigint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                System.Int64? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6567857530072268079L));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int64? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
    int64bigint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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
                System.Int64? nullable = null;
                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3453012791097202233L));
                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(2292766920896876586L));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64? nullable = null;
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3909672445520646420L));
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(7528223743640677420L));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigint0M> models = null;

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigint0M> models = null;

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await ((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await ((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64SingleTypebigint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigint0M.AssertModel(models[0],_testData[19], false);
                        Int64bigint0M.AssertModel(models[1],_testData[20], false);
                        Int64bigint0M.AssertModel(models[2],_testData[21], false);
                        Int64bigint0M.AssertModel(models[3],_testData[22], false);
                        Int64bigint0M.AssertModel(models[4],_testData[23], false);
                        Int64bigint0M.AssertModel(models[5],_testData[24], false);
                        Int64bigint0M.AssertModel(models[6],_testData[25], false);
                        Int64bigint0M.AssertModel(models[7],_testData[26], false);
                        Int64bigint0M.AssertModel(models[8],_testData[27], false);
                        Int64bigint0M.AssertModel(models[9],_testData[28], false);
                        Int64bigint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigint0M.AssertModel(models[0],_testData[18], false);
                        Int64bigint0M.AssertModel(models[1],_testData[19], false);
                        Int64bigint0M.AssertModel(models[2],_testData[20], false);
                        Int64bigint0M.AssertModel(models[3],_testData[21], false);
                        Int64bigint0M.AssertModel(models[4],_testData[22], false);
                        Int64bigint0M.AssertModel(models[5],_testData[23], false);
                        Int64bigint0M.AssertModel(models[6],_testData[24], false);
                        Int64bigint0M.AssertModel(models[7],_testData[25], false);
                        Int64bigint0M.AssertModel(models[8],_testData[26], false);
                        Int64bigint0M.AssertModel(models[9],_testData[27], false);
                        Int64bigint0M.AssertModel(models[10],_testData[28], false);
                        Int64bigint0M.AssertModel(models[11],_testData[29], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[26], false);
                        Int64bigint0M.AssertModel(models[1],_testData[27], false);
                        Int64bigint0M.AssertModel(models[2],_testData[28], false);
                        Int64bigint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigint0M.AssertModel(models[0],_testData[11], false);
                        Int64bigint0M.AssertModel(models[1],_testData[12], false);
                        Int64bigint0M.AssertModel(models[2],_testData[13], false);
                        Int64bigint0M.AssertModel(models[3],_testData[14], false);
                        Int64bigint0M.AssertModel(models[4],_testData[15], false);
                        Int64bigint0M.AssertModel(models[5],_testData[16], false);
                        Int64bigint0M.AssertModel(models[6],_testData[17], false);
                        Int64bigint0M.AssertModel(models[7],_testData[18], false);
                        Int64bigint0M.AssertModel(models[8],_testData[19], false);
                        Int64bigint0M.AssertModel(models[9],_testData[20], false);
                        Int64bigint0M.AssertModel(models[10],_testData[21], false);
                        Int64bigint0M.AssertModel(models[11],_testData[22], false);
                        Int64bigint0M.AssertModel(models[12],_testData[23], false);
                        Int64bigint0M.AssertModel(models[13],_testData[24], false);
                        Int64bigint0M.AssertModel(models[14],_testData[25], false);
                        Int64bigint0M.AssertModel(models[15],_testData[26], false);
                        Int64bigint0M.AssertModel(models[16],_testData[27], false);
                        Int64bigint0M.AssertModel(models[17],_testData[28], false);
                        Int64bigint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 94, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigint0M.AssertModel(models[0],_testData[21], false);
                        Int64bigint0M.AssertModel(models[1],_testData[22], false);
                        Int64bigint0M.AssertModel(models[2],_testData[23], false);
                        Int64bigint0M.AssertModel(models[3],_testData[24], false);
                        Int64bigint0M.AssertModel(models[4],_testData[25], false);
                        Int64bigint0M.AssertModel(models[5],_testData[26], false);
                        Int64bigint0M.AssertModel(models[6],_testData[27], false);
                        Int64bigint0M.AssertModel(models[7],_testData[28], false);
                        Int64bigint0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigint0M.AssertModel(models[0],_testData[20], false);
                        Int64bigint0M.AssertModel(models[1],_testData[21], false);
                        Int64bigint0M.AssertModel(models[2],_testData[22], false);
                        Int64bigint0M.AssertModel(models[3],_testData[23], false);
                        Int64bigint0M.AssertModel(models[4],_testData[24], false);
                        Int64bigint0M.AssertModel(models[5],_testData[25], false);
                        Int64bigint0M.AssertModel(models[6],_testData[26], false);
                        Int64bigint0M.AssertModel(models[7],_testData[27], false);
                        Int64bigint0M.AssertModel(models[8],_testData[28], false);
                        Int64bigint0M.AssertModel(models[9],_testData[29], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 61, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigint0M.AssertModel(models[0],_testData[9], false);
                        Int64bigint0M.AssertModel(models[1],_testData[10], false);
                        Int64bigint0M.AssertModel(models[2],_testData[11], false);
                        Int64bigint0M.AssertModel(models[3],_testData[12], false);
                        Int64bigint0M.AssertModel(models[4],_testData[13], false);
                        Int64bigint0M.AssertModel(models[5],_testData[14], false);
                        Int64bigint0M.AssertModel(models[6],_testData[15], false);
                        Int64bigint0M.AssertModel(models[7],_testData[16], false);
                        Int64bigint0M.AssertModel(models[8],_testData[17], false);
                        Int64bigint0M.AssertModel(models[9],_testData[18], false);
                        Int64bigint0M.AssertModel(models[10],_testData[19], false);
                        Int64bigint0M.AssertModel(models[11],_testData[20], false);
                        Int64bigint0M.AssertModel(models[12],_testData[21], false);
                        Int64bigint0M.AssertModel(models[13],_testData[22], false);
                        Int64bigint0M.AssertModel(models[14],_testData[23], false);
                        Int64bigint0M.AssertModel(models[15],_testData[24], false);
                        Int64bigint0M.AssertModel(models[16],_testData[25], false);
                        Int64bigint0M.AssertModel(models[17],_testData[26], false);
                        Int64bigint0M.AssertModel(models[18],_testData[27], false);
                        Int64bigint0M.AssertModel(models[19],_testData[28], false);
                        Int64bigint0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigint0M.AssertModel(models[0],_testData[12], false);
                        Int64bigint0M.AssertModel(models[1],_testData[13], false);
                        Int64bigint0M.AssertModel(models[2],_testData[14], false);
                        Int64bigint0M.AssertModel(models[3],_testData[15], false);
                        Int64bigint0M.AssertModel(models[4],_testData[16], false);
                        Int64bigint0M.AssertModel(models[5],_testData[17], false);
                        Int64bigint0M.AssertModel(models[6],_testData[18], false);
                        Int64bigint0M.AssertModel(models[7],_testData[19], false);
                        Int64bigint0M.AssertModel(models[8],_testData[20], false);
                        Int64bigint0M.AssertModel(models[9],_testData[21], false);
                        Int64bigint0M.AssertModel(models[10],_testData[22], false);
                        Int64bigint0M.AssertModel(models[11],_testData[23], false);
                        Int64bigint0M.AssertModel(models[12],_testData[24], false);
                        Int64bigint0M.AssertModel(models[13],_testData[25], false);
                        Int64bigint0M.AssertModel(models[14],_testData[26], false);
                        Int64bigint0M.AssertModel(models[15],_testData[27], false);
                        Int64bigint0M.AssertModel(models[16],_testData[28], false);
                        Int64bigint0M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int64bigint0M.AssertModel(models[0],_testData[3], false);Int64bigint0M.AssertModel(models[1],_testData[4], false);Int64bigint0M.AssertModel(models[2],_testData[5], false);Int64bigint0M.AssertModel(models[3],_testData[6], false);Int64bigint0M.AssertModel(models[4],_testData[7], false);Int64bigint0M.AssertModel(models[5],_testData[8], false);Int64bigint0M.AssertModel(models[6],_testData[9], false);Int64bigint0M.AssertModel(models[7],_testData[10], false);Int64bigint0M.AssertModel(models[8],_testData[11], false);Int64bigint0M.AssertModel(models[9],_testData[12], false);Int64bigint0M.AssertModel(models[10],_testData[13], false);Int64bigint0M.AssertModel(models[11],_testData[14], false);Int64bigint0M.AssertModel(models[12],_testData[15], false);Int64bigint0M.AssertModel(models[13],_testData[16], false);Int64bigint0M.AssertModel(models[14],_testData[17], false);Int64bigint0M.AssertModel(models[15],_testData[18], false);Int64bigint0M.AssertModel(models[16],_testData[19], false);Int64bigint0M.AssertModel(models[17],_testData[20], false);Int64bigint0M.AssertModel(models[18],_testData[21], false);Int64bigint0M.AssertModel(models[19],_testData[22], false);Int64bigint0M.AssertModel(models[20],_testData[23], false);Int64bigint0M.AssertModel(models[21],_testData[24], false);Int64bigint0M.AssertModel(models[22],_testData[25], false);Int64bigint0M.AssertModel(models[23],_testData[26], false);Int64bigint0M.AssertModel(models[24],_testData[27], false);Int64bigint0M.AssertModel(models[25],_testData[28], false);Int64bigint0M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Int64bigint0M.AssertModel(models[0],_testData[15], false);Int64bigint0M.AssertModel(models[1],_testData[16], false);Int64bigint0M.AssertModel(models[2],_testData[17], false);Int64bigint0M.AssertModel(models[3],_testData[18], false);Int64bigint0M.AssertModel(models[4],_testData[19], false);Int64bigint0M.AssertModel(models[5],_testData[20], false);Int64bigint0M.AssertModel(models[6],_testData[21], false);Int64bigint0M.AssertModel(models[7],_testData[22], false);Int64bigint0M.AssertModel(models[8],_testData[23], false);Int64bigint0M.AssertModel(models[9],_testData[24], false);Int64bigint0M.AssertModel(models[10],_testData[25], false);Int64bigint0M.AssertModel(models[11],_testData[26], false);Int64bigint0M.AssertModel(models[12],_testData[27], false);Int64bigint0M.AssertModel(models[13],_testData[28], false);Int64bigint0M.AssertModel(models[14],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6320177536023134646L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8182961652293282965L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2260341245603816766L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6919956141001141566L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8189041842432689283L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((885619918680017247L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6080256549268164562L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6935231367160177391L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1908382142313681154L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6567857530072268079L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7635153938630418795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2026075049265269259L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1963234981372421114L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2903150859676782954L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5934354963079124650L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((856032276856104032L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3453012791097202233L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((510236586542681645L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8939899319610628007L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3654036059215105497L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2292766920896876586L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6323896510321392674L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3909672445520646420L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7549368032961242334L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8139766044309136518L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7528223743640677420L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7997793702670227201L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6733532585434789269L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8985700612099061903L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6003787958356996386L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6090400691469335122L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7106502544352726649L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7825900716233069378L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2765536247150252162L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((199774296955969756L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((178063161201897312L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5394405118145873698L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5124268619221783352L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9048139052795103924L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8731435116295339237L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4656834645870025348L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5141078451286056906L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1900397710133036008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6005207016962624831L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2046081990408718159L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3133622804421631109L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5744194786600901726L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3608129241022571854L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2659791078325729452L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1353278630710346967L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((55186773814009392L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((355026703709934861L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4732823843795091961L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((552574029429224279L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6089150398820138284L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4051781517164558853L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3408397999732272290L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1703044129603123291L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((453332578666117564L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4378312240024747984L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8282403303646819544L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4072803244080110487L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5874157146664911923L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2864410354144717667L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6320177536023134646L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8182961652293282965L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2260341245603816766L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6919956141001141566L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8189041842432689283L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((885619918680017247L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6080256549268164562L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6935231367160177391L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1908382142313681154L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6567857530072268079L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7635153938630418795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2026075049265269259L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1963234981372421114L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2903150859676782954L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5934354963079124650L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((856032276856104032L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3453012791097202233L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((510236586542681645L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8939899319610628007L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3654036059215105497L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2292766920896876586L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6323896510321392674L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3909672445520646420L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7549368032961242334L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8139766044309136518L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7528223743640677420L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7997793702670227201L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6733532585434789269L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8985700612099061903L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6003787958356996386L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6090400691469335122L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7106502544352726649L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7825900716233069378L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2765536247150252162L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((199774296955969756L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((178063161201897312L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5394405118145873698L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5124268619221783352L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9048139052795103924L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8731435116295339237L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4656834645870025348L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5141078451286056906L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1900397710133036008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6005207016962624831L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2046081990408718159L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3133622804421631109L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5744194786600901726L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3608129241022571854L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2659791078325729452L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1353278630710346967L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((55186773814009392L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((355026703709934861L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4732823843795091961L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((552574029429224279L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6089150398820138284L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4051781517164558853L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3408397999732272290L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1703044129603123291L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((453332578666117564L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4378312240024747984L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8282403303646819544L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4072803244080110487L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5874157146664911923L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2864410354144717667L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
FROM public.binary_int64bigint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigint0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64SingleTypebigint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
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
                await ((IInt64SingleTypebigint)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64SingleTypebigint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
FROM public.binary_int64bigint0m m
LEFT JOIN public.binary_int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigint0M>(15);

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
                ((IInt64SingleTypebigint)this).ImportModel(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigint0M.AssertModel(models[0],_testData[0], false);
                Int64bigint0M.AssertModel(models[1],_testData[1], false);
                Int64bigint0M.AssertModel(models[2],_testData[2], false);
                Int64bigint0M.AssertModel(models[3],_testData[3], false);
                Int64bigint0M.AssertModel(models[4],_testData[4], false);
                Int64bigint0M.AssertModel(models[5],_testData[5], false);
                Int64bigint0M.AssertModel(models[6],_testData[6], false);
                Int64bigint0M.AssertModel(models[7],_testData[7], false);
                Int64bigint0M.AssertModel(models[8],_testData[8], false);
                Int64bigint0M.AssertModel(models[9],_testData[9], false);
                Int64bigint0M.AssertModel(models[10],_testData[10], false);
                Int64bigint0M.AssertModel(models[11],_testData[11], false);
                Int64bigint0M.AssertModel(models[12],_testData[12], false);
                Int64bigint0M.AssertModel(models[13],_testData[13], false);
                Int64bigint0M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt64SingleTypebigint)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64SingleTypebigint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigint0M.AssertModel(models[0],_testData[0], false);
                Int64bigint0M.AssertModel(models[1],_testData[1], false);
                Int64bigint0M.AssertModel(models[2],_testData[2], false);
                Int64bigint0M.AssertModel(models[3],_testData[3], false);
                Int64bigint0M.AssertModel(models[4],_testData[4], false);
                Int64bigint0M.AssertModel(models[5],_testData[5], false);
                Int64bigint0M.AssertModel(models[6],_testData[6], false);
                Int64bigint0M.AssertModel(models[7],_testData[7], false);
                Int64bigint0M.AssertModel(models[8],_testData[8], false);
                Int64bigint0M.AssertModel(models[9],_testData[9], false);
                Int64bigint0M.AssertModel(models[10],_testData[10], false);
                Int64bigint0M.AssertModel(models[11],_testData[11], false);
                Int64bigint0M.AssertModel(models[12],_testData[12], false);
                Int64bigint0M.AssertModel(models[13],_testData[13], false);
                Int64bigint0M.AssertModel(models[14],_testData[14], false);
                Int64bigint0M.AssertModel(models[15],_testData[15], false);
                Int64bigint0M.AssertModel(models[16],_testData[16], false);
                Int64bigint0M.AssertModel(models[17],_testData[17], false);
                Int64bigint0M.AssertModel(models[18],_testData[18], false);
                Int64bigint0M.AssertModel(models[19],_testData[19], false);
                Int64bigint0M.AssertModel(models[20],_testData[20], false);
                Int64bigint0M.AssertModel(models[21],_testData[21], false);
                Int64bigint0M.AssertModel(models[22],_testData[22], false);
                Int64bigint0M.AssertModel(models[23],_testData[23], false);
                Int64bigint0M.AssertModel(models[24],_testData[24], false);
                Int64bigint0M.AssertModel(models[25],_testData[25], false);
                Int64bigint0M.AssertModel(models[26],_testData[26], false);
                Int64bigint0M.AssertModel(models[27],_testData[27], false);
                Int64bigint0M.AssertModel(models[28],_testData[28], false);
                Int64bigint0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

