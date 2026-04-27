

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

        private readonly Charchar0M[] _testData = new Charchar0M[]
        {
            new Charchar0M
{
    Id = 5,
    Value = 'w',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 6,
    Value = 's',
    ModelInner = new Charchar0MI
{
    Id = 6,
    Value = 's',
    NullableValue = null,
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 9,
    Value = 'c',
    ModelInner = null,
    NullableValue = 'f',
},
            new Charchar0M
{
    Id = 16,
    Value = 'g',
    ModelInner = new Charchar0MI
{
    Id = 9,
    Value = 'm',
    NullableValue = 'p',
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 25,
    Value = 'h',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 31,
    Value = 'c',
    ModelInner = new Charchar0MI
{
    Id = 13,
    Value = 'e',
    NullableValue = 'l',
},
    NullableValue = 'g',
},
            new Charchar0M
{
    Id = 34,
    Value = 'l',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 41,
    Value = 'b',
    ModelInner = new Charchar0MI
{
    Id = 19,
    Value = 'b',
    NullableValue = 'p',
},
    NullableValue = 'g',
},
            new Charchar0M
{
    Id = 49,
    Value = 'g',
    ModelInner = null,
    NullableValue = 'm',
},
            new Charchar0M
{
    Id = 56,
    Value = 'k',
    ModelInner = new Charchar0MI
{
    Id = 25,
    Value = 'm',
    NullableValue = 'g',
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 57,
    Value = 'y',
    ModelInner = null,
    NullableValue = 'c',
},
            new Charchar0M
{
    Id = 58,
    Value = 'r',
    ModelInner = new Charchar0MI
{
    Id = 27,
    Value = 'l',
    NullableValue = null,
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 61,
    Value = 'w',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 70,
    Value = 'x',
    ModelInner = new Charchar0MI
{
    Id = 30,
    Value = 'q',
    NullableValue = 'm',
},
    NullableValue = 'e',
},
            new Charchar0M
{
    Id = 74,
    Value = 't',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 80,
    Value = 't',
    ModelInner = new Charchar0MI
{
    Id = 34,
    Value = 'w',
    NullableValue = 'r',
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 82,
    Value = 'a',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 87,
    Value = 's',
    ModelInner = new Charchar0MI
{
    Id = 39,
    Value = 'y',
    NullableValue = 'n',
},
    NullableValue = 'u',
},
            new Charchar0M
{
    Id = 93,
    Value = 'v',
    ModelInner = null,
    NullableValue = 'c',
},
            new Charchar0M
{
    Id = 101,
    Value = 'q',
    ModelInner = new Charchar0MI
{
    Id = 42,
    Value = 'g',
    NullableValue = null,
},
    NullableValue = 'n',
},
            new Charchar0M
{
    Id = 109,
    Value = 'i',
    ModelInner = null,
    NullableValue = 'x',
},
            new Charchar0M
{
    Id = 116,
    Value = 'w',
    ModelInner = new Charchar0MI
{
    Id = 51,
    Value = 'a',
    NullableValue = 'k',
},
    NullableValue = 'y',
},
            new Charchar0M
{
    Id = 122,
    Value = 'k',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 126,
    Value = 'k',
    ModelInner = new Charchar0MI
{
    Id = 56,
    Value = 'f',
    NullableValue = 'h',
},
    NullableValue = 'd',
},
            new Charchar0M
{
    Id = 133,
    Value = 'p',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 134,
    Value = 's',
    ModelInner = new Charchar0MI
{
    Id = 61,
    Value = 'b',
    NullableValue = 'n',
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 142,
    Value = 's',
    ModelInner = null,
    NullableValue = null,
},
            new Charchar0M
{
    Id = 143,
    Value = 'g',
    ModelInner = new Charchar0MI
{
    Id = 69,
    Value = 'h',
    NullableValue = null,
},
    NullableValue = null,
},
            new Charchar0M
{
    Id = 152,
    Value = 't',
    ModelInner = null,
    NullableValue = 'o',
},
            new Charchar0M
{
    Id = 153,
    Value = 'h',
    ModelInner = new Charchar0MI
{
    Id = 76,
    Value = 'i',
    NullableValue = 'y',
},
    NullableValue = null,
},
        };

#endregion

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
            queryMapTypes: [typeof(Charchar0MI)],
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
                methodParametrName: "charchar0mi_id", 
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
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Charchar0M)],
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
            queryMapTypes: [typeof(Charchar0M)],
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
                methodParametrName: "charchar0mi_id", 
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
                List<Charchar0M> models = null;

                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[4], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[5], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[6], true);
                models =  ((ICharSingleTypechar)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Charchar0M> models = null;

                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[8], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[9], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[10], true);
                models = await ((ICharSingleTypechar)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Charchar0M.AssertModel(models[0],_testData[11], true);
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
                parametrName: "charchar0mi_id", 
                methodParametrName: "charchar0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharchar0M), typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                ((ICharSingleTypechar)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ICharSingleTypechar)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ICharSingleTypechar)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
LEFT JOIN public.charchar0mi mi ON mi.id = m.charchar0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Charchar0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharchar0M), typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                ((ICharSingleTypechar)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ICharSingleTypechar)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ICharSingleTypechar)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
LEFT JOIN public.charchar0mi mi ON mi.id = m.charchar0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Charchar0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharchar0M), typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                await((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatCharchar0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatCharchar0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatCharchar0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[29], false);
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchar0m m
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
FROM public.charchar0m m
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatCharchar0M.AssertModel(models[0],_testData[1], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[2], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[3], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[4], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[5], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[6], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[7], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[8], false);
                        FlatCharchar0M.AssertModel(models[8],_testData[9], false);
                        FlatCharchar0M.AssertModel(models[9],_testData[10], false);
                        FlatCharchar0M.AssertModel(models[10],_testData[11], false);
                        FlatCharchar0M.AssertModel(models[11],_testData[12], false);
                        FlatCharchar0M.AssertModel(models[12],_testData[13], false);
                        FlatCharchar0M.AssertModel(models[13],_testData[14], false);
                        FlatCharchar0M.AssertModel(models[14],_testData[15], false);
                        FlatCharchar0M.AssertModel(models[15],_testData[16], false);
                        FlatCharchar0M.AssertModel(models[16],_testData[17], false);
                        FlatCharchar0M.AssertModel(models[17],_testData[18], false);
                        FlatCharchar0M.AssertModel(models[18],_testData[19], false);
                        FlatCharchar0M.AssertModel(models[19],_testData[20], false);
                        FlatCharchar0M.AssertModel(models[20],_testData[21], false);
                        FlatCharchar0M.AssertModel(models[21],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[22],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[23],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[24],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[25],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[26],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[27],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatCharchar0M.AssertModel(models[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.charchar0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchar0m m
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
FROM public.charchar0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatCharchar0M.AssertModel(models[0],_testData[12], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[13], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[14], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[15], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[16], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[17], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[18], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[19], false);
                        FlatCharchar0M.AssertModel(models[8],_testData[20], false);
                        FlatCharchar0M.AssertModel(models[9],_testData[21], false);
                        FlatCharchar0M.AssertModel(models[10],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[11],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[12],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[13],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[14],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[15],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[16],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatCharchar0M.AssertModel(models[0],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[19],_testData[29], false);
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
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Charchar0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Charchar0M.AssertModel(models[0],_testData[26], false);
                        Charchar0M.AssertModel(models[1],_testData[27], false);
                        Charchar0M.AssertModel(models[2],_testData[28], false);
                        Charchar0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Charchar0M.AssertModel(models[0],_testData[19], false);
                        Charchar0M.AssertModel(models[1],_testData[20], false);
                        Charchar0M.AssertModel(models[2],_testData[21], false);
                        Charchar0M.AssertModel(models[3],_testData[22], false);
                        Charchar0M.AssertModel(models[4],_testData[23], false);
                        Charchar0M.AssertModel(models[5],_testData[24], false);
                        Charchar0M.AssertModel(models[6],_testData[25], false);
                        Charchar0M.AssertModel(models[7],_testData[26], false);
                        Charchar0M.AssertModel(models[8],_testData[27], false);
                        Charchar0M.AssertModel(models[9],_testData[28], false);
                        Charchar0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Charchar0M.AssertModel(models[0],_testData[6], false);
                        Charchar0M.AssertModel(models[1],_testData[7], false);
                        Charchar0M.AssertModel(models[2],_testData[8], false);
                        Charchar0M.AssertModel(models[3],_testData[9], false);
                        Charchar0M.AssertModel(models[4],_testData[10], false);
                        Charchar0M.AssertModel(models[5],_testData[11], false);
                        Charchar0M.AssertModel(models[6],_testData[12], false);
                        Charchar0M.AssertModel(models[7],_testData[13], false);
                        Charchar0M.AssertModel(models[8],_testData[14], false);
                        Charchar0M.AssertModel(models[9],_testData[15], false);
                        Charchar0M.AssertModel(models[10],_testData[16], false);
                        Charchar0M.AssertModel(models[11],_testData[17], false);
                        Charchar0M.AssertModel(models[12],_testData[18], false);
                        Charchar0M.AssertModel(models[13],_testData[19], false);
                        Charchar0M.AssertModel(models[14],_testData[20], false);
                        Charchar0M.AssertModel(models[15],_testData[21], false);
                        Charchar0M.AssertModel(models[16],_testData[22], false);
                        Charchar0M.AssertModel(models[17],_testData[23], false);
                        Charchar0M.AssertModel(models[18],_testData[24], false);
                        Charchar0M.AssertModel(models[19],_testData[25], false);
                        Charchar0M.AssertModel(models[20],_testData[26], false);
                        Charchar0M.AssertModel(models[21],_testData[27], false);
                        Charchar0M.AssertModel(models[22],_testData[28], false);
                        Charchar0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Charchar0M.AssertModel(models[0],_testData[9], false);
                        Charchar0M.AssertModel(models[1],_testData[10], false);
                        Charchar0M.AssertModel(models[2],_testData[11], false);
                        Charchar0M.AssertModel(models[3],_testData[12], false);
                        Charchar0M.AssertModel(models[4],_testData[13], false);
                        Charchar0M.AssertModel(models[5],_testData[14], false);
                        Charchar0M.AssertModel(models[6],_testData[15], false);
                        Charchar0M.AssertModel(models[7],_testData[16], false);
                        Charchar0M.AssertModel(models[8],_testData[17], false);
                        Charchar0M.AssertModel(models[9],_testData[18], false);
                        Charchar0M.AssertModel(models[10],_testData[19], false);
                        Charchar0M.AssertModel(models[11],_testData[20], false);
                        Charchar0M.AssertModel(models[12],_testData[21], false);
                        Charchar0M.AssertModel(models[13],_testData[22], false);
                        Charchar0M.AssertModel(models[14],_testData[23], false);
                        Charchar0M.AssertModel(models[15],_testData[24], false);
                        Charchar0M.AssertModel(models[16],_testData[25], false);
                        Charchar0M.AssertModel(models[17],_testData[26], false);
                        Charchar0M.AssertModel(models[18],_testData[27], false);
                        Charchar0M.AssertModel(models[19],_testData[28], false);
                        Charchar0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharchar0M), typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                await((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[19],_testData[29], false);
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatCharchar0M>();
                var models2 = new List<FlatCharchar0M>();
                ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var firstItems2 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionMMDynQuerySelectModelBatch(connection, 5, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatCharchar0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatCharchar0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatCharchar0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatCharchar0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatCharchar0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatCharchar0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatCharchar0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatCharchar0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatCharchar0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatCharchar0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatCharchar0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatCharchar0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatCharchar0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatCharchar0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatCharchar0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatCharchar0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatCharchar0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatCharchar0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatCharchar0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatCharchar0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatCharchar0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatCharchar0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatCharchar0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatCharchar0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatCharchar0M)],
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatCharchar0M.AssertModel(models[0],_testData[15], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[16], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[17], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[18], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[19], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[20], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[21], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[8],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[9],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[10],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[11],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[12],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[13],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatCharchar0M.AssertModel(models[0],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[29], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                await ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatCharchar0M.AssertModel(models[i],_testData[i], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatCharchar0M.AssertModel(models[0],_testData[19], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[20], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[21], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[8],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[9],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatCharchar0M.AssertModel(models[0],_testData[9], false);
                        FlatCharchar0M.AssertModel(models[1],_testData[10], false);
                        FlatCharchar0M.AssertModel(models[2],_testData[11], false);
                        FlatCharchar0M.AssertModel(models[3],_testData[12], false);
                        FlatCharchar0M.AssertModel(models[4],_testData[13], false);
                        FlatCharchar0M.AssertModel(models[5],_testData[14], false);
                        FlatCharchar0M.AssertModel(models[6],_testData[15], false);
                        FlatCharchar0M.AssertModel(models[7],_testData[16], false);
                        FlatCharchar0M.AssertModel(models[8],_testData[17], false);
                        FlatCharchar0M.AssertModel(models[9],_testData[18], false);
                        FlatCharchar0M.AssertModel(models[10],_testData[19], false);
                        FlatCharchar0M.AssertModel(models[11],_testData[20], false);
                        FlatCharchar0M.AssertModel(models[12],_testData[21], false);
                        FlatCharchar0M.AssertModel(models[13],_testData[22], false);
                        FlatCharchar0M.AssertModel(models[14],_testData[23], false);
                        FlatCharchar0M.AssertModel(models[15],_testData[24], false);
                        FlatCharchar0M.AssertModel(models[16],_testData[25], false);
                        FlatCharchar0M.AssertModel(models[17],_testData[26], false);
                        FlatCharchar0M.AssertModel(models[18],_testData[27], false);
                        FlatCharchar0M.AssertModel(models[19],_testData[28], false);
                        FlatCharchar0M.AssertModel(models[20],_testData[29], false);
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
FROM public.charchar0m m
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
FROM public.charchar0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatCharchar0M>();
                var secondItems1 = new List<FlatCharchar0M>();
                var secondItems2 = new List<FlatCharchar0M>();
                 ((ICharSingleTypechar)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatCharchar0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatCharchar0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatCharchar0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatCharchar0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatCharchar0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatCharchar0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatCharchar0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatCharchar0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatCharchar0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatCharchar0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatCharchar0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatCharchar0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatCharchar0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatCharchar0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatCharchar0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatCharchar0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatCharchar0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatCharchar0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatCharchar0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatCharchar0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatCharchar0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatCharchar0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatCharchar0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatCharchar0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatCharchar0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatCharchar0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatCharchar0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatCharchar0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatCharchar0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatCharchar0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatCharchar0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatCharchar0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatCharchar0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatCharchar0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatCharchar0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatCharchar0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatCharchar0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatCharchar0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatCharchar0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatCharchar0M.AssertModel(secondItems2[27],_testData[29], false);
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
            queryMapTypes: [typeof(Charchar0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ICharSingleTypechar)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Charchar0M.AssertModel(models[0],_testData[16], false);
                        Charchar0M.AssertModel(models[1],_testData[17], false);
                        Charchar0M.AssertModel(models[2],_testData[18], false);
                        Charchar0M.AssertModel(models[3],_testData[19], false);
                        Charchar0M.AssertModel(models[4],_testData[20], false);
                        Charchar0M.AssertModel(models[5],_testData[21], false);
                        Charchar0M.AssertModel(models[6],_testData[22], false);
                        Charchar0M.AssertModel(models[7],_testData[23], false);
                        Charchar0M.AssertModel(models[8],_testData[24], false);
                        Charchar0M.AssertModel(models[9],_testData[25], false);
                        Charchar0M.AssertModel(models[10],_testData[26], false);
                        Charchar0M.AssertModel(models[11],_testData[27], false);
                        Charchar0M.AssertModel(models[12],_testData[28], false);
                        Charchar0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Charchar0M.AssertModel(models[0],_testData[17], false);
                        Charchar0M.AssertModel(models[1],_testData[18], false);
                        Charchar0M.AssertModel(models[2],_testData[19], false);
                        Charchar0M.AssertModel(models[3],_testData[20], false);
                        Charchar0M.AssertModel(models[4],_testData[21], false);
                        Charchar0M.AssertModel(models[5],_testData[22], false);
                        Charchar0M.AssertModel(models[6],_testData[23], false);
                        Charchar0M.AssertModel(models[7],_testData[24], false);
                        Charchar0M.AssertModel(models[8],_testData[25], false);
                        Charchar0M.AssertModel(models[9],_testData[26], false);
                        Charchar0M.AssertModel(models[10],_testData[27], false);
                        Charchar0M.AssertModel(models[11],_testData[28], false);
                        Charchar0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Charchar0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ICharSingleTypechar)this).DbConnectionSTSelectModelBatch(connection, 31, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Charchar0M.AssertModel(models[0],_testData[6], false);
                        Charchar0M.AssertModel(models[1],_testData[7], false);
                        Charchar0M.AssertModel(models[2],_testData[8], false);
                        Charchar0M.AssertModel(models[3],_testData[9], false);
                        Charchar0M.AssertModel(models[4],_testData[10], false);
                        Charchar0M.AssertModel(models[5],_testData[11], false);
                        Charchar0M.AssertModel(models[6],_testData[12], false);
                        Charchar0M.AssertModel(models[7],_testData[13], false);
                        Charchar0M.AssertModel(models[8],_testData[14], false);
                        Charchar0M.AssertModel(models[9],_testData[15], false);
                        Charchar0M.AssertModel(models[10],_testData[16], false);
                        Charchar0M.AssertModel(models[11],_testData[17], false);
                        Charchar0M.AssertModel(models[12],_testData[18], false);
                        Charchar0M.AssertModel(models[13],_testData[19], false);
                        Charchar0M.AssertModel(models[14],_testData[20], false);
                        Charchar0M.AssertModel(models[15],_testData[21], false);
                        Charchar0M.AssertModel(models[16],_testData[22], false);
                        Charchar0M.AssertModel(models[17],_testData[23], false);
                        Charchar0M.AssertModel(models[18],_testData[24], false);
                        Charchar0M.AssertModel(models[19],_testData[25], false);
                        Charchar0M.AssertModel(models[20],_testData[26], false);
                        Charchar0M.AssertModel(models[21],_testData[27], false);
                        Charchar0M.AssertModel(models[22],_testData[28], false);
                        Charchar0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Charchar0M.AssertModel(models[0],_testData[6], false);
                        Charchar0M.AssertModel(models[1],_testData[7], false);
                        Charchar0M.AssertModel(models[2],_testData[8], false);
                        Charchar0M.AssertModel(models[3],_testData[9], false);
                        Charchar0M.AssertModel(models[4],_testData[10], false);
                        Charchar0M.AssertModel(models[5],_testData[11], false);
                        Charchar0M.AssertModel(models[6],_testData[12], false);
                        Charchar0M.AssertModel(models[7],_testData[13], false);
                        Charchar0M.AssertModel(models[8],_testData[14], false);
                        Charchar0M.AssertModel(models[9],_testData[15], false);
                        Charchar0M.AssertModel(models[10],_testData[16], false);
                        Charchar0M.AssertModel(models[11],_testData[17], false);
                        Charchar0M.AssertModel(models[12],_testData[18], false);
                        Charchar0M.AssertModel(models[13],_testData[19], false);
                        Charchar0M.AssertModel(models[14],_testData[20], false);
                        Charchar0M.AssertModel(models[15],_testData[21], false);
                        Charchar0M.AssertModel(models[16],_testData[22], false);
                        Charchar0M.AssertModel(models[17],_testData[23], false);
                        Charchar0M.AssertModel(models[18],_testData[24], false);
                        Charchar0M.AssertModel(models[19],_testData[25], false);
                        Charchar0M.AssertModel(models[20],_testData[26], false);
                        Charchar0M.AssertModel(models[21],_testData[27], false);
                        Charchar0M.AssertModel(models[22],_testData[28], false);
                        Charchar0M.AssertModel(models[23],_testData[29], false);
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
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
Charchar0M.AssertModel(models[0],_testData[2], false);Charchar0M.AssertModel(models[1],_testData[3], false);Charchar0M.AssertModel(models[2],_testData[4], false);Charchar0M.AssertModel(models[3],_testData[5], false);Charchar0M.AssertModel(models[4],_testData[6], false);Charchar0M.AssertModel(models[5],_testData[7], false);Charchar0M.AssertModel(models[6],_testData[8], false);Charchar0M.AssertModel(models[7],_testData[9], false);Charchar0M.AssertModel(models[8],_testData[10], false);Charchar0M.AssertModel(models[9],_testData[11], false);Charchar0M.AssertModel(models[10],_testData[12], false);Charchar0M.AssertModel(models[11],_testData[13], false);Charchar0M.AssertModel(models[12],_testData[14], false);Charchar0M.AssertModel(models[13],_testData[15], false);Charchar0M.AssertModel(models[14],_testData[16], false);Charchar0M.AssertModel(models[15],_testData[17], false);Charchar0M.AssertModel(models[16],_testData[18], false);Charchar0M.AssertModel(models[17],_testData[19], false);Charchar0M.AssertModel(models[18],_testData[20], false);Charchar0M.AssertModel(models[19],_testData[21], false);Charchar0M.AssertModel(models[20],_testData[22], false);Charchar0M.AssertModel(models[21],_testData[23], false);Charchar0M.AssertModel(models[22],_testData[24], false);Charchar0M.AssertModel(models[23],_testData[25], false);Charchar0M.AssertModel(models[24],_testData[26], false);Charchar0M.AssertModel(models[25],_testData[27], false);Charchar0M.AssertModel(models[26],_testData[28], false);Charchar0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ICharSingleTypechar)this).CreateDbConnectionSelectModelCommand(connection);
                ((ICharSingleTypechar)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((ICharSingleTypechar)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Charchar0M.AssertModel(models[0],_testData[7], false);Charchar0M.AssertModel(models[1],_testData[8], false);Charchar0M.AssertModel(models[2],_testData[9], false);Charchar0M.AssertModel(models[3],_testData[10], false);Charchar0M.AssertModel(models[4],_testData[11], false);Charchar0M.AssertModel(models[5],_testData[12], false);Charchar0M.AssertModel(models[6],_testData[13], false);Charchar0M.AssertModel(models[7],_testData[14], false);Charchar0M.AssertModel(models[8],_testData[15], false);Charchar0M.AssertModel(models[9],_testData[16], false);Charchar0M.AssertModel(models[10],_testData[17], false);Charchar0M.AssertModel(models[11],_testData[18], false);Charchar0M.AssertModel(models[12],_testData[19], false);Charchar0M.AssertModel(models[13],_testData[20], false);Charchar0M.AssertModel(models[14],_testData[21], false);Charchar0M.AssertModel(models[15],_testData[22], false);Charchar0M.AssertModel(models[16],_testData[23], false);Charchar0M.AssertModel(models[17],_testData[24], false);Charchar0M.AssertModel(models[18],_testData[25], false);Charchar0M.AssertModel(models[19],_testData[26], false);Charchar0M.AssertModel(models[20],_testData[27], false);Charchar0M.AssertModel(models[21],_testData[28], false);Charchar0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('s').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('f').ToString()));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('p').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('l').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('l').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('p').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('g').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('l').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('q').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('m').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('e').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('r').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('a').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('n').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('v').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('i').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('a').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('y').ToString()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('f').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('n').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('h').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('o').ToString()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('i').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ICharSingleTypechar)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('s').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('f').ToString()));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('p').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('c').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('e').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('l').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('l').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('b').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('p').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('g').ToString()));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('m').ToString()));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('m').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('g').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('y').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('r').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('l').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('x').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('q').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('m').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('e').ToString()));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('w').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('r').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('a').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('y').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('n').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('u').ToString()));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('v').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('c').ToString()));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('q').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('g').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(('n').ToString()));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('i').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('x').ToString()));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('w').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('a').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('k').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('y').ToString()));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('k').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('f').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('h').ToString()));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('d').ToString()));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('p').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('b').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('n').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('s').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('g').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('h').ToString()));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('t').ToString()));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(('o').ToString()));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(('h').ToString()));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(('i').ToString()));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(('y').ToString()));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
            queryMapTypes: [typeof(Charchar0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Charchar0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ICharSingleTypechar)this).ImportModelInner(connection, importCollection);
                var models = ((ICharSingleTypechar)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Charchar0MI.AssertModel(actual, expect, false);
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
                await ((ICharSingleTypechar)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ICharSingleTypechar)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Charchar0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
FROM public.binary_charchar0m m
LEFT JOIN public.binary_charchar0mi mi ON mi.id = m.charchar0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Charchar0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ICharSingleTypechar))]
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
                ((ICharSingleTypechar)this).ImportModel(connection, importCollection);
                var models = ((ICharSingleTypechar)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Charchar0M.AssertModel(models[0],_testData[0], false);
                Charchar0M.AssertModel(models[1],_testData[1], false);
                Charchar0M.AssertModel(models[2],_testData[2], false);
                Charchar0M.AssertModel(models[3],_testData[3], false);
                Charchar0M.AssertModel(models[4],_testData[4], false);
                Charchar0M.AssertModel(models[5],_testData[5], false);
                Charchar0M.AssertModel(models[6],_testData[6], false);
                Charchar0M.AssertModel(models[7],_testData[7], false);
                Charchar0M.AssertModel(models[8],_testData[8], false);
                Charchar0M.AssertModel(models[9],_testData[9], false);
                Charchar0M.AssertModel(models[10],_testData[10], false);
                Charchar0M.AssertModel(models[11],_testData[11], false);
                Charchar0M.AssertModel(models[12],_testData[12], false);
                Charchar0M.AssertModel(models[13],_testData[13], false);
                Charchar0M.AssertModel(models[14],_testData[14], false);
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
                await ((ICharSingleTypechar)this).ImportModelAsync(connection, importCollection);
                models = await ((ICharSingleTypechar)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Charchar0M.AssertModel(models[0],_testData[0], false);
                Charchar0M.AssertModel(models[1],_testData[1], false);
                Charchar0M.AssertModel(models[2],_testData[2], false);
                Charchar0M.AssertModel(models[3],_testData[3], false);
                Charchar0M.AssertModel(models[4],_testData[4], false);
                Charchar0M.AssertModel(models[5],_testData[5], false);
                Charchar0M.AssertModel(models[6],_testData[6], false);
                Charchar0M.AssertModel(models[7],_testData[7], false);
                Charchar0M.AssertModel(models[8],_testData[8], false);
                Charchar0M.AssertModel(models[9],_testData[9], false);
                Charchar0M.AssertModel(models[10],_testData[10], false);
                Charchar0M.AssertModel(models[11],_testData[11], false);
                Charchar0M.AssertModel(models[12],_testData[12], false);
                Charchar0M.AssertModel(models[13],_testData[13], false);
                Charchar0M.AssertModel(models[14],_testData[14], false);
                Charchar0M.AssertModel(models[15],_testData[15], false);
                Charchar0M.AssertModel(models[16],_testData[16], false);
                Charchar0M.AssertModel(models[17],_testData[17], false);
                Charchar0M.AssertModel(models[18],_testData[18], false);
                Charchar0M.AssertModel(models[19],_testData[19], false);
                Charchar0M.AssertModel(models[20],_testData[20], false);
                Charchar0M.AssertModel(models[21],_testData[21], false);
                Charchar0M.AssertModel(models[22],_testData[22], false);
                Charchar0M.AssertModel(models[23],_testData[23], false);
                Charchar0M.AssertModel(models[24],_testData[24], false);
                Charchar0M.AssertModel(models[25],_testData[25], false);
                Charchar0M.AssertModel(models[26],_testData[26], false);
                Charchar0M.AssertModel(models[27],_testData[27], false);
                Charchar0M.AssertModel(models[28],_testData[28], false);
                Charchar0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_charchar0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    charchar0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Charchar0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    Charchar0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    Charchar0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_charchar0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Charchar0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ICharSingleTypechar)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Charchar0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ICharSingleTypechar)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Charchar0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

