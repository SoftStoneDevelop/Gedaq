

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


#region TestData

        private readonly CharcharE0M[] _testData = new CharcharE0M[]
        {
            new CharcharE0M
{
    Id = 6,
    Value = 'd',
    ModelInner = null,
    NullableValue = 'b',
},
            new CharcharE0M
{
    Id = 8,
    Value = 'n',
    ModelInner = new CharcharE0MI
{
    Id = 3,
    Value = 'k',
    NullableValue = 'h',
},
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 15,
    Value = 'w',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 20,
    Value = 'n',
    ModelInner = new CharcharE0MI
{
    Id = 10,
    Value = 'p',
    NullableValue = null,
},
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 28,
    Value = 'w',
    ModelInner = null,
    NullableValue = 'a',
},
            new CharcharE0M
{
    Id = 37,
    Value = 'k',
    ModelInner = new CharcharE0MI
{
    Id = 14,
    Value = 'r',
    NullableValue = null,
},
    NullableValue = 'q',
},
            new CharcharE0M
{
    Id = 41,
    Value = 'c',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 42,
    Value = 'n',
    ModelInner = new CharcharE0MI
{
    Id = 20,
    Value = 'o',
    NullableValue = null,
},
    NullableValue = 't',
},
            new CharcharE0M
{
    Id = 50,
    Value = 'd',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 51,
    Value = 'b',
    ModelInner = new CharcharE0MI
{
    Id = 29,
    Value = 't',
    NullableValue = 'm',
},
    NullableValue = 'w',
},
            new CharcharE0M
{
    Id = 57,
    Value = 'k',
    ModelInner = null,
    NullableValue = 'd',
},
            new CharcharE0M
{
    Id = 60,
    Value = 'q',
    ModelInner = new CharcharE0MI
{
    Id = 35,
    Value = 'e',
    NullableValue = 'k',
},
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 69,
    Value = 'b',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 71,
    Value = 's',
    ModelInner = new CharcharE0MI
{
    Id = 40,
    Value = 'r',
    NullableValue = 'y',
},
    NullableValue = 'k',
},
            new CharcharE0M
{
    Id = 75,
    Value = 'w',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 84,
    Value = 'x',
    ModelInner = new CharcharE0MI
{
    Id = 43,
    Value = 'c',
    NullableValue = null,
},
    NullableValue = 'm',
},
            new CharcharE0M
{
    Id = 86,
    Value = 'h',
    ModelInner = null,
    NullableValue = 'n',
},
            new CharcharE0M
{
    Id = 94,
    Value = 's',
    ModelInner = new CharcharE0MI
{
    Id = 46,
    Value = 'q',
    NullableValue = null,
},
    NullableValue = 't',
},
            new CharcharE0M
{
    Id = 99,
    Value = 'f',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 100,
    Value = 'k',
    ModelInner = new CharcharE0MI
{
    Id = 49,
    Value = 'w',
    NullableValue = null,
},
    NullableValue = 'k',
},
            new CharcharE0M
{
    Id = 103,
    Value = 'k',
    ModelInner = null,
    NullableValue = 'n',
},
            new CharcharE0M
{
    Id = 112,
    Value = 'u',
    ModelInner = new CharcharE0MI
{
    Id = 53,
    Value = 'x',
    NullableValue = 'f',
},
    NullableValue = 'q',
},
            new CharcharE0M
{
    Id = 119,
    Value = 'x',
    ModelInner = null,
    NullableValue = 'l',
},
            new CharcharE0M
{
    Id = 125,
    Value = 'c',
    ModelInner = new CharcharE0MI
{
    Id = 59,
    Value = 'b',
    NullableValue = null,
},
    NullableValue = 'r',
},
            new CharcharE0M
{
    Id = 133,
    Value = 'e',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 138,
    Value = 'l',
    ModelInner = new CharcharE0MI
{
    Id = 65,
    Value = 'o',
    NullableValue = 'o',
},
    NullableValue = 'd',
},
            new CharcharE0M
{
    Id = 139,
    Value = 'n',
    ModelInner = null,
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 145,
    Value = 'w',
    ModelInner = new CharcharE0MI
{
    Id = 68,
    Value = 'u',
    NullableValue = 'o',
},
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 147,
    Value = 'm',
    ModelInner = null,
    NullableValue = 't',
},
            new CharcharE0M
{
    Id = 151,
    Value = 'e',
    ModelInner = new CharcharE0MI
{
    Id = 70,
    Value = 'l',
    NullableValue = 'v',
},
    NullableValue = 'v',
},
            new CharcharE0M
{
    Id = 157,
    Value = 'm',
    ModelInner = null,
    NullableValue = 'j',
},
            new CharcharE0M
{
    Id = 163,
    Value = 'r',
    ModelInner = new CharcharE0MI
{
    Id = 78,
    Value = 'o',
    NullableValue = null,
},
    NullableValue = null,
},
            new CharcharE0M
{
    Id = 169,
    Value = 'p',
    ModelInner = null,
    NullableValue = 'g',
},
            new CharcharE0M
{
    Id = 178,
    Value = 'y',
    ModelInner = new CharcharE0MI
{
    Id = 83,
    Value = 'd',
    NullableValue = 'g',
},
    NullableValue = 'b',
},
            new CharcharE0M
{
    Id = 185,
    Value = 'f',
    ModelInner = null,
    NullableValue = 'o',
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchare0mi(
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
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchare0mi(
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
            queryMapTypes: [typeof(CharcharE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6))]
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

                changedRows =  ((ICharSingleTypechar)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ICharSingleTypechar)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ICharSingleTypechar)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ICharSingleTypechar)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ICharSingleTypechar)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ICharSingleTypechar)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ICharSingleTypechar)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.charchare0mi(
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
            asPartInterface: typeof(ICharSingleTypechar)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Char), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16), 
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

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchare0m(
	id,
    value,
    nullablevalue,
    charchare0mi_id
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
            asPartInterface: typeof(ICharSingleTypechar)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "charchare0mi_id", 
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
                changedRows =  ((ICharSingleTypechar)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ICharSingleTypechar)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ICharSingleTypechar)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ICharSingleTypechar)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchare0m(
	id,
    value,
    nullablevalue,
    charchare0mi_id
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
    charchare0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(CharcharE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.charchare0m(
	id,
    value,
    nullablevalue,
    charchare0mi_id
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
    charchare0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(CharcharE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Char?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(6)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "charchare0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
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

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<CharcharE0M> models = null;

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[4], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[5], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[6], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<CharcharE0M> models = null;

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[8], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[9], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[10], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                CharcharE0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.charchare0m(
	id,
    value,
    nullablevalue,
    charchare0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @charchare0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
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
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "charchare0mi_id", 
                methodParametrName: "charchare0mi_id", 
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

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ICharSingleTypechar)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ICharSingleTypechar)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharcharE0M), typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                ((ICharSingleTypechar)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ICharSingleTypechar)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ICharSingleTypechar)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
LEFT JOIN public.charchare0mi mi ON mi.id = m.charchare0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(CharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
                var models = await ((ICharSingleTypechar)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ICharSingleTypechar)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharcharE0M), typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                ((ICharSingleTypechar)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ICharSingleTypechar)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ICharSingleTypechar)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
LEFT JOIN public.charchare0mi mi ON mi.id = m.charchare0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(CharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
                var models = await ((ICharSingleTypechar)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ICharSingleTypechar)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharcharE0M), typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                await((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 71;
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr2.Value = 86;
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatCharcharE0M.AssertModel(models[0],_testData[2], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[3], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[4], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[5], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[6], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[7], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[8], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[9], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[10], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[11], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[12], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[13], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[14], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[15], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[16], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[17], false);
                        FlatCharcharE0M.AssertModel(models[16],_testData[18], false);
                        FlatCharcharE0M.AssertModel(models[17],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[18],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[19],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[20],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[21],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[22],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[23],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[24],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[25],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[26],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[27],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[28],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[29],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[30],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[31],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatCharcharE0M.AssertModel(models[0],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 50;
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatCharcharE0M.AssertModel(models[0],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatCharcharE0M.AssertModel(models[0],_testData[4], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[5], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[6], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[7], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[8], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[9], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[10], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[11], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[12], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[13], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[14], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[15], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[16], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[17], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[18], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[16],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[17],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[18],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[19],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[20],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[21],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[22],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[23],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[24],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[25],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[26],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[27],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[28],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[29],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.charchare0m m
LEFT JOIN public.charchare0mi mi ON mi.id = m.charchare0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(CharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
                var models = await((ICharSingleTypechar)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        CharcharE0M.AssertModel(models[0],_testData[24], false);
                        CharcharE0M.AssertModel(models[1],_testData[25], false);
                        CharcharE0M.AssertModel(models[2],_testData[26], false);
                        CharcharE0M.AssertModel(models[3],_testData[27], false);
                        CharcharE0M.AssertModel(models[4],_testData[28], false);
                        CharcharE0M.AssertModel(models[5],_testData[29], false);
                        CharcharE0M.AssertModel(models[6],_testData[30], false);
                        CharcharE0M.AssertModel(models[7],_testData[31], false);
                        CharcharE0M.AssertModel(models[8],_testData[32], false);
                        CharcharE0M.AssertModel(models[9],_testData[33], false);
                        CharcharE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        CharcharE0M.AssertModel(models[0],_testData[1], false);
                        CharcharE0M.AssertModel(models[1],_testData[2], false);
                        CharcharE0M.AssertModel(models[2],_testData[3], false);
                        CharcharE0M.AssertModel(models[3],_testData[4], false);
                        CharcharE0M.AssertModel(models[4],_testData[5], false);
                        CharcharE0M.AssertModel(models[5],_testData[6], false);
                        CharcharE0M.AssertModel(models[6],_testData[7], false);
                        CharcharE0M.AssertModel(models[7],_testData[8], false);
                        CharcharE0M.AssertModel(models[8],_testData[9], false);
                        CharcharE0M.AssertModel(models[9],_testData[10], false);
                        CharcharE0M.AssertModel(models[10],_testData[11], false);
                        CharcharE0M.AssertModel(models[11],_testData[12], false);
                        CharcharE0M.AssertModel(models[12],_testData[13], false);
                        CharcharE0M.AssertModel(models[13],_testData[14], false);
                        CharcharE0M.AssertModel(models[14],_testData[15], false);
                        CharcharE0M.AssertModel(models[15],_testData[16], false);
                        CharcharE0M.AssertModel(models[16],_testData[17], false);
                        CharcharE0M.AssertModel(models[17],_testData[18], false);
                        CharcharE0M.AssertModel(models[18],_testData[19], false);
                        CharcharE0M.AssertModel(models[19],_testData[20], false);
                        CharcharE0M.AssertModel(models[20],_testData[21], false);
                        CharcharE0M.AssertModel(models[21],_testData[22], false);
                        CharcharE0M.AssertModel(models[22],_testData[23], false);
                        CharcharE0M.AssertModel(models[23],_testData[24], false);
                        CharcharE0M.AssertModel(models[24],_testData[25], false);
                        CharcharE0M.AssertModel(models[25],_testData[26], false);
                        CharcharE0M.AssertModel(models[26],_testData[27], false);
                        CharcharE0M.AssertModel(models[27],_testData[28], false);
                        CharcharE0M.AssertModel(models[28],_testData[29], false);
                        CharcharE0M.AssertModel(models[29],_testData[30], false);
                        CharcharE0M.AssertModel(models[30],_testData[31], false);
                        CharcharE0M.AssertModel(models[31],_testData[32], false);
                        CharcharE0M.AssertModel(models[32],_testData[33], false);
                        CharcharE0M.AssertModel(models[33],_testData[34], false);
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
                var models = ((ICharSingleTypechar)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        CharcharE0M.AssertModel(models[0],_testData[16], false);
                        CharcharE0M.AssertModel(models[1],_testData[17], false);
                        CharcharE0M.AssertModel(models[2],_testData[18], false);
                        CharcharE0M.AssertModel(models[3],_testData[19], false);
                        CharcharE0M.AssertModel(models[4],_testData[20], false);
                        CharcharE0M.AssertModel(models[5],_testData[21], false);
                        CharcharE0M.AssertModel(models[6],_testData[22], false);
                        CharcharE0M.AssertModel(models[7],_testData[23], false);
                        CharcharE0M.AssertModel(models[8],_testData[24], false);
                        CharcharE0M.AssertModel(models[9],_testData[25], false);
                        CharcharE0M.AssertModel(models[10],_testData[26], false);
                        CharcharE0M.AssertModel(models[11],_testData[27], false);
                        CharcharE0M.AssertModel(models[12],_testData[28], false);
                        CharcharE0M.AssertModel(models[13],_testData[29], false);
                        CharcharE0M.AssertModel(models[14],_testData[30], false);
                        CharcharE0M.AssertModel(models[15],_testData[31], false);
                        CharcharE0M.AssertModel(models[16],_testData[32], false);
                        CharcharE0M.AssertModel(models[17],_testData[33], false);
                        CharcharE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        CharcharE0M.AssertModel(models[0],_testData[19], false);
                        CharcharE0M.AssertModel(models[1],_testData[20], false);
                        CharcharE0M.AssertModel(models[2],_testData[21], false);
                        CharcharE0M.AssertModel(models[3],_testData[22], false);
                        CharcharE0M.AssertModel(models[4],_testData[23], false);
                        CharcharE0M.AssertModel(models[5],_testData[24], false);
                        CharcharE0M.AssertModel(models[6],_testData[25], false);
                        CharcharE0M.AssertModel(models[7],_testData[26], false);
                        CharcharE0M.AssertModel(models[8],_testData[27], false);
                        CharcharE0M.AssertModel(models[9],_testData[28], false);
                        CharcharE0M.AssertModel(models[10],_testData[29], false);
                        CharcharE0M.AssertModel(models[11],_testData[30], false);
                        CharcharE0M.AssertModel(models[12],_testData[31], false);
                        CharcharE0M.AssertModel(models[13],_testData[32], false);
                        CharcharE0M.AssertModel(models[14],_testData[33], false);
                        CharcharE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharcharE0M), typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                await((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharcharE0M>();
                var models2 = new List<FlatCharcharE0M>();
                ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models1[i],_testData[i], false);
                    FlatCharcharE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 57, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var firstItems2 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatCharcharE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatCharcharE0M.AssertModel(models[0],_testData[2], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[3], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[4], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[5], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[6], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[7], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[8], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[9], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[10], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[11], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[12], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[13], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[14], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[15], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[16], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[17], false);
                        FlatCharcharE0M.AssertModel(models[16],_testData[18], false);
                        FlatCharcharE0M.AssertModel(models[17],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[18],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[19],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[20],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[21],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[22],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[23],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[24],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[25],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[26],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[27],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[28],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[29],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[30],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[31],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatCharcharE0M.AssertModel(models[0],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[34], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                await ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 50, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatCharcharE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatCharcharE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatCharcharE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatCharcharE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatCharcharE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatCharcharE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatCharcharE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatCharcharE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatCharcharE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatCharcharE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatCharcharE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatCharcharE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatCharcharE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatCharcharE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatCharcharE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatCharcharE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatCharcharE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatCharcharE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatCharcharE0M.AssertModel(models[0],_testData[2], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[3], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[4], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[5], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[6], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[7], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[8], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[9], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[10], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[11], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[12], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[13], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[14], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[15], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[16], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[17], false);
                        FlatCharcharE0M.AssertModel(models[16],_testData[18], false);
                        FlatCharcharE0M.AssertModel(models[17],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[18],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[19],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[20],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[21],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[22],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[23],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[24],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[25],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[26],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[27],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[28],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[29],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[30],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[31],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatCharcharE0M.AssertModel(models[0],_testData[5], false);
                        FlatCharcharE0M.AssertModel(models[1],_testData[6], false);
                        FlatCharcharE0M.AssertModel(models[2],_testData[7], false);
                        FlatCharcharE0M.AssertModel(models[3],_testData[8], false);
                        FlatCharcharE0M.AssertModel(models[4],_testData[9], false);
                        FlatCharcharE0M.AssertModel(models[5],_testData[10], false);
                        FlatCharcharE0M.AssertModel(models[6],_testData[11], false);
                        FlatCharcharE0M.AssertModel(models[7],_testData[12], false);
                        FlatCharcharE0M.AssertModel(models[8],_testData[13], false);
                        FlatCharcharE0M.AssertModel(models[9],_testData[14], false);
                        FlatCharcharE0M.AssertModel(models[10],_testData[15], false);
                        FlatCharcharE0M.AssertModel(models[11],_testData[16], false);
                        FlatCharcharE0M.AssertModel(models[12],_testData[17], false);
                        FlatCharcharE0M.AssertModel(models[13],_testData[18], false);
                        FlatCharcharE0M.AssertModel(models[14],_testData[19], false);
                        FlatCharcharE0M.AssertModel(models[15],_testData[20], false);
                        FlatCharcharE0M.AssertModel(models[16],_testData[21], false);
                        FlatCharcharE0M.AssertModel(models[17],_testData[22], false);
                        FlatCharcharE0M.AssertModel(models[18],_testData[23], false);
                        FlatCharcharE0M.AssertModel(models[19],_testData[24], false);
                        FlatCharcharE0M.AssertModel(models[20],_testData[25], false);
                        FlatCharcharE0M.AssertModel(models[21],_testData[26], false);
                        FlatCharcharE0M.AssertModel(models[22],_testData[27], false);
                        FlatCharcharE0M.AssertModel(models[23],_testData[28], false);
                        FlatCharcharE0M.AssertModel(models[24],_testData[29], false);
                        FlatCharcharE0M.AssertModel(models[25],_testData[30], false);
                        FlatCharcharE0M.AssertModel(models[26],_testData[31], false);
                        FlatCharcharE0M.AssertModel(models[27],_testData[32], false);
                        FlatCharcharE0M.AssertModel(models[28],_testData[33], false);
                        FlatCharcharE0M.AssertModel(models[29],_testData[34], false);
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
FROM public.charchare0m m
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
FROM public.charchare0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharcharE0M>();
                var secondItems1 = new List<FlatCharcharE0M>();
                var secondItems2 = new List<FlatCharcharE0M>();
                 ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatCharcharE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatCharcharE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatCharcharE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatCharcharE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatCharcharE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatCharcharE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatCharcharE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatCharcharE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatCharcharE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatCharcharE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatCharcharE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatCharcharE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatCharcharE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatCharcharE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatCharcharE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatCharcharE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatCharcharE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatCharcharE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatCharcharE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatCharcharE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatCharcharE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatCharcharE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatCharcharE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatCharcharE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatCharcharE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatCharcharE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatCharcharE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatCharcharE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatCharcharE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatCharcharE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatCharcharE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatCharcharE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatCharcharE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatCharcharE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatCharcharE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.charchare0m m
LEFT JOIN public.charchare0mi mi ON mi.id = m.charchare0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(CharcharE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
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
            asPartInterface: typeof(ICharSingleTypechar)),
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
                var models = await((ICharSingleTypechar)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        CharcharE0M.AssertModel(models[0],_testData[31], false);
                        CharcharE0M.AssertModel(models[1],_testData[32], false);
                        CharcharE0M.AssertModel(models[2],_testData[33], false);
                        CharcharE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        CharcharE0M.AssertModel(models[0],_testData[3], false);
                        CharcharE0M.AssertModel(models[1],_testData[4], false);
                        CharcharE0M.AssertModel(models[2],_testData[5], false);
                        CharcharE0M.AssertModel(models[3],_testData[6], false);
                        CharcharE0M.AssertModel(models[4],_testData[7], false);
                        CharcharE0M.AssertModel(models[5],_testData[8], false);
                        CharcharE0M.AssertModel(models[6],_testData[9], false);
                        CharcharE0M.AssertModel(models[7],_testData[10], false);
                        CharcharE0M.AssertModel(models[8],_testData[11], false);
                        CharcharE0M.AssertModel(models[9],_testData[12], false);
                        CharcharE0M.AssertModel(models[10],_testData[13], false);
                        CharcharE0M.AssertModel(models[11],_testData[14], false);
                        CharcharE0M.AssertModel(models[12],_testData[15], false);
                        CharcharE0M.AssertModel(models[13],_testData[16], false);
                        CharcharE0M.AssertModel(models[14],_testData[17], false);
                        CharcharE0M.AssertModel(models[15],_testData[18], false);
                        CharcharE0M.AssertModel(models[16],_testData[19], false);
                        CharcharE0M.AssertModel(models[17],_testData[20], false);
                        CharcharE0M.AssertModel(models[18],_testData[21], false);
                        CharcharE0M.AssertModel(models[19],_testData[22], false);
                        CharcharE0M.AssertModel(models[20],_testData[23], false);
                        CharcharE0M.AssertModel(models[21],_testData[24], false);
                        CharcharE0M.AssertModel(models[22],_testData[25], false);
                        CharcharE0M.AssertModel(models[23],_testData[26], false);
                        CharcharE0M.AssertModel(models[24],_testData[27], false);
                        CharcharE0M.AssertModel(models[25],_testData[28], false);
                        CharcharE0M.AssertModel(models[26],_testData[29], false);
                        CharcharE0M.AssertModel(models[27],_testData[30], false);
                        CharcharE0M.AssertModel(models[28],_testData[31], false);
                        CharcharE0M.AssertModel(models[29],_testData[32], false);
                        CharcharE0M.AssertModel(models[30],_testData[33], false);
                        CharcharE0M.AssertModel(models[31],_testData[34], false);
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
                var models = ((ICharSingleTypechar)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    CharcharE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTSelectModelBatch(connection, 138, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        CharcharE0M.AssertModel(models[0],_testData[26], false);
                        CharcharE0M.AssertModel(models[1],_testData[27], false);
                        CharcharE0M.AssertModel(models[2],_testData[28], false);
                        CharcharE0M.AssertModel(models[3],_testData[29], false);
                        CharcharE0M.AssertModel(models[4],_testData[30], false);
                        CharcharE0M.AssertModel(models[5],_testData[31], false);
                        CharcharE0M.AssertModel(models[6],_testData[32], false);
                        CharcharE0M.AssertModel(models[7],_testData[33], false);
                        CharcharE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        CharcharE0M.AssertModel(models[0],_testData[24], false);
                        CharcharE0M.AssertModel(models[1],_testData[25], false);
                        CharcharE0M.AssertModel(models[2],_testData[26], false);
                        CharcharE0M.AssertModel(models[3],_testData[27], false);
                        CharcharE0M.AssertModel(models[4],_testData[28], false);
                        CharcharE0M.AssertModel(models[5],_testData[29], false);
                        CharcharE0M.AssertModel(models[6],_testData[30], false);
                        CharcharE0M.AssertModel(models[7],_testData[31], false);
                        CharcharE0M.AssertModel(models[8],_testData[32], false);
                        CharcharE0M.AssertModel(models[9],_testData[33], false);
                        CharcharE0M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((ICharSingleTypechar)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models = await ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                CharcharE0M.AssertModel(models[0],_testData[14], false);
                CharcharE0M.AssertModel(models[1],_testData[15], false);
                CharcharE0M.AssertModel(models[2],_testData[16], false);
                CharcharE0M.AssertModel(models[3],_testData[17], false);
                CharcharE0M.AssertModel(models[4],_testData[18], false);
                CharcharE0M.AssertModel(models[5],_testData[19], false);
                CharcharE0M.AssertModel(models[6],_testData[20], false);
                CharcharE0M.AssertModel(models[7],_testData[21], false);
                CharcharE0M.AssertModel(models[8],_testData[22], false);
                CharcharE0M.AssertModel(models[9],_testData[23], false);
                CharcharE0M.AssertModel(models[10],_testData[24], false);
                CharcharE0M.AssertModel(models[11],_testData[25], false);
                CharcharE0M.AssertModel(models[12],_testData[26], false);
                CharcharE0M.AssertModel(models[13],_testData[27], false);
                CharcharE0M.AssertModel(models[14],_testData[28], false);
                CharcharE0M.AssertModel(models[15],_testData[29], false);
                CharcharE0M.AssertModel(models[16],_testData[30], false);
                CharcharE0M.AssertModel(models[17],_testData[31], false);
                CharcharE0M.AssertModel(models[18],_testData[32], false);
                CharcharE0M.AssertModel(models[19],_testData[33], false);
                CharcharE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ICharSingleTypechar)this).CreateDbConnectionSelectModelCommand(connection);
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                CharcharE0M.AssertModel(models[0],_testData[20], false);
                CharcharE0M.AssertModel(models[1],_testData[21], false);
                CharcharE0M.AssertModel(models[2],_testData[22], false);
                CharcharE0M.AssertModel(models[3],_testData[23], false);
                CharcharE0M.AssertModel(models[4],_testData[24], false);
                CharcharE0M.AssertModel(models[5],_testData[25], false);
                CharcharE0M.AssertModel(models[6],_testData[26], false);
                CharcharE0M.AssertModel(models[7],_testData[27], false);
                CharcharE0M.AssertModel(models[8],_testData[28], false);
                CharcharE0M.AssertModel(models[9],_testData[29], false);
                CharcharE0M.AssertModel(models[10],_testData[30], false);
                CharcharE0M.AssertModel(models[11],_testData[31], false);
                CharcharE0M.AssertModel(models[12],_testData[32], false);
                CharcharE0M.AssertModel(models[13],_testData[33], false);
                CharcharE0M.AssertModel(models[14],_testData[34], false);
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
FROM public.charchare0m m
LEFT JOIN public.charchare0mi mi ON mi.id = m.charchare0mi_id
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
            asPartInterface: typeof(ICharSingleTypechar))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('b').ToString()));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('k').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('p').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('a').ToString()));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('q').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('t').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('m').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('w').ToString()));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('k').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('c').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('q').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('k').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('u').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('x').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('f').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('q').ToString()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('l').ToString()));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('l').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('u').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('m').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('l').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('v').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('v').ToString()));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('m').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('j').ToString()));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('d').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('g').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('b').ToString()));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('o').ToString()));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ICharSingleTypechar)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('b').ToString()));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('k').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('p').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('a').ToString()));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('q').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('d').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('t').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('m').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('w').ToString()));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('r').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('k').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('c').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('q').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('k').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('u').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('x').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('f').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('q').ToString()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('l').ToString()));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('r').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('l').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('n').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('u').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('o').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('m').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('t').ToString()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('e').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('l').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('v').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('v').ToString()));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('m').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('j').ToString()));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('o').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('d').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('g').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('b').ToString()));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('f').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('o').ToString()));

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
FROM public.binary_charchare0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(CharcharE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ICharSingleTypechar)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_charchare0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ICharSingleTypechar)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ICharSingleTypechar)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_charchare0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ICharSingleTypechar)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_charchare0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(CharcharE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ICharSingleTypechar)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_charchare0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ICharSingleTypechar)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ICharSingleTypechar)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_charchare0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ICharSingleTypechar)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_charchare0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(CharcharE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_charchare0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(CharcharE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<CharcharE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ICharSingleTypechar)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ICharSingleTypechar)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<CharcharE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ICharSingleTypechar)this).WAImportModelInner(connection, importCollection);
                var models = ((ICharSingleTypechar)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_charchare0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_charchare0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(CharcharE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ICharSingleTypechar)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ICharSingleTypechar)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<CharcharE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new CharcharE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ICharSingleTypechar)this).ImportModelInner(connection, importCollection);
                var models = ((ICharSingleTypechar)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_charchare0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
charchare0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(CharcharE0M),
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
FROM public.binary_charchare0m m
LEFT JOIN public.binary_charchare0mi mi ON mi.id = m.charchare0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(CharcharE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<CharcharE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ICharSingleTypechar)this).ImportModelAsync(connection, importCollection);
                var models = await ((ICharSingleTypechar)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    CharcharE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<CharcharE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ICharSingleTypechar)this).ImportModel(connection, importCollection);
                var models = ((ICharSingleTypechar)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    CharcharE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_charchare0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    charchare0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(CharcharE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
                var models =  ((ICharSingleTypechar)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    CharcharE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    CharcharE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA), typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                await ((ICharSingleTypechar)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                ((ICharSingleTypechar)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
                var models = await ((ICharSingleTypechar)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_charchare0mi
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
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ICharSingleTypechar)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_charchare0mi
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
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA), typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                await ((ICharSingleTypechar)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                ((ICharSingleTypechar)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
                var models = await ((ICharSingleTypechar)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_charchare0mi
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
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ICharSingleTypechar)this).DynQueryExportModelInner(connection, @"
COPY public.binary_charchare0mi
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
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(CharcharE0MI), typeof(CharcharE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
                var models1 = new List<CharcharE0MI>();
                var models2 = new List<CharcharE0MI>();
                await ((ICharSingleTypechar)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<CharcharE0MI>();
                var models2 = new List<CharcharE0MI>();
                ((ICharSingleTypechar)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_charchare0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(CharcharE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(6),
                (NpgsqlTypes.NpgsqlDbType)(6)
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
                var models = await ((ICharSingleTypechar)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    CharcharE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((ICharSingleTypechar)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    CharcharE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_charchare0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA), typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                await ((ICharSingleTypechar)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<CharcharE0MIWA>();
                var models2 = new List<CharcharE0MIWA>();
                ((ICharSingleTypechar)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_charchare0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(CharcharE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
                var models = await ((ICharSingleTypechar)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ICharSingleTypechar)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    CharcharE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

