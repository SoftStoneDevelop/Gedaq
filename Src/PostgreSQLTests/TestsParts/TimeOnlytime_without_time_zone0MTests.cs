

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
    internal partial interface ITimeOnlySingleTypetime_without_time_zone
    {
    }
    
    internal partial class TimeOnlySingleTypetime_without_time_zone : ITimeOnlySingleTypetime_without_time_zone
    {


#region TestData

        private readonly TimeOnlytime_without_time_zone0M[] _testData = new TimeOnlytime_without_time_zone0M[]
        {
            new TimeOnlytime_without_time_zone0M
{
    Id = 2,
    Value = new TimeOnly(hour: 0, minute: 23, second: 40, millisecond: 834),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 21, minute: 56, second: 18, millisecond: 399),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 5,
    Value = new TimeOnly(hour: 13, minute: 28, second: 44, millisecond: 247),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 8,
    Value = new TimeOnly(hour: 18, minute: 2, second: 13, millisecond: 784),
    NullableValue = new TimeOnly(hour: 22, minute: 47, second: 25, millisecond: 576),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 11,
    Value = new TimeOnly(hour: 20, minute: 44, second: 58, millisecond: 943),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 20, minute: 9, second: 38, millisecond: 182),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 14,
    Value = new TimeOnly(hour: 22, minute: 22, second: 41, millisecond: 186),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 14,
    Value = new TimeOnly(hour: 17, minute: 26, second: 25, millisecond: 676),
    NullableValue = new TimeOnly(hour: 7, minute: 0, second: 30, millisecond: 369),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 22,
    Value = new TimeOnly(hour: 22, minute: 57, second: 37, millisecond: 287),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 30,
    Value = new TimeOnly(hour: 8, minute: 5, second: 9, millisecond: 307),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 19,
    Value = new TimeOnly(hour: 3, minute: 5, second: 32, millisecond: 474),
    NullableValue = new TimeOnly(hour: 8, minute: 40, second: 29, millisecond: 183),
},
    NullableValue = new TimeOnly(hour: 22, minute: 17, second: 42, millisecond: 281),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 39,
    Value = new TimeOnly(hour: 9, minute: 46, second: 24, millisecond: 316),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 7, minute: 15, second: 11, millisecond: 736),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 48,
    Value = new TimeOnly(hour: 7, minute: 44, second: 2, millisecond: 320),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 20,
    Value = new TimeOnly(hour: 20, minute: 7, second: 43, millisecond: 514),
    NullableValue = new TimeOnly(hour: 2, minute: 48, second: 42, millisecond: 434),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 57,
    Value = new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 958),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 65,
    Value = new TimeOnly(hour: 16, minute: 0, second: 16, millisecond: 967),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 24,
    Value = new TimeOnly(hour: 8, minute: 27, second: 41, millisecond: 371),
    NullableValue = null,
},
    NullableValue = new TimeOnly(hour: 6, minute: 56, second: 18, millisecond: 474),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 67,
    Value = new TimeOnly(hour: 13, minute: 49, second: 19, millisecond: 509),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 3, minute: 58, second: 44, millisecond: 474),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 72,
    Value = new TimeOnly(hour: 11, minute: 9, second: 27, millisecond: 623),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 32,
    Value = new TimeOnly(hour: 12, minute: 36, second: 4, millisecond: 130),
    NullableValue = null,
},
    NullableValue = new TimeOnly(hour: 15, minute: 27, second: 47, millisecond: 513),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 79,
    Value = new TimeOnly(hour: 14, minute: 24, second: 31, millisecond: 395),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 3, minute: 3, second: 7, millisecond: 986),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 82,
    Value = new TimeOnly(hour: 10, minute: 28, second: 40, millisecond: 117),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 39,
    Value = new TimeOnly(hour: 20, minute: 40, second: 37, millisecond: 869),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 90,
    Value = new TimeOnly(hour: 5, minute: 5, second: 8, millisecond: 404),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 94,
    Value = new TimeOnly(hour: 7, minute: 11, second: 5, millisecond: 210),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 46,
    Value = new TimeOnly(hour: 22, minute: 57, second: 57, millisecond: 422),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 100,
    Value = new TimeOnly(hour: 4, minute: 38, second: 20, millisecond: 73),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 4, minute: 12, second: 14, millisecond: 710),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 108,
    Value = new TimeOnly(hour: 4, minute: 23, second: 57, millisecond: 984),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 49,
    Value = new TimeOnly(hour: 20, minute: 46, second: 27, millisecond: 650),
    NullableValue = new TimeOnly(hour: 8, minute: 49, second: 21, millisecond: 598),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 113,
    Value = new TimeOnly(hour: 0, minute: 58, second: 38, millisecond: 195),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 7, minute: 53, second: 14, millisecond: 532),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 116,
    Value = new TimeOnly(hour: 5, minute: 8, second: 23, millisecond: 622),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 51,
    Value = new TimeOnly(hour: 11, minute: 37, second: 52, millisecond: 845),
    NullableValue = new TimeOnly(hour: 16, minute: 2, second: 18, millisecond: 748),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 124,
    Value = new TimeOnly(hour: 18, minute: 52, second: 33, millisecond: 415),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 125,
    Value = new TimeOnly(hour: 4, minute: 46, second: 18, millisecond: 457),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 59,
    Value = new TimeOnly(hour: 14, minute: 31, second: 20, millisecond: 105),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 132,
    Value = new TimeOnly(hour: 22, minute: 44, second: 13, millisecond: 76),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 22, minute: 11, second: 12, millisecond: 159),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 138,
    Value = new TimeOnly(hour: 7, minute: 36, second: 9, millisecond: 697),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 60,
    Value = new TimeOnly(hour: 2, minute: 54, second: 52, millisecond: 366),
    NullableValue = new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 772),
},
    NullableValue = new TimeOnly(hour: 1, minute: 38, second: 9, millisecond: 534),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 143,
    Value = new TimeOnly(hour: 5, minute: 8, second: 26, millisecond: 412),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 273),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 151,
    Value = new TimeOnly(hour: 11, minute: 35, second: 40, millisecond: 130),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 63,
    Value = new TimeOnly(hour: 1, minute: 18, second: 38, millisecond: 751),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 159,
    Value = new TimeOnly(hour: 15, minute: 23, second: 39, millisecond: 694),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 6, minute: 5, second: 43, millisecond: 171),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 160,
    Value = new TimeOnly(hour: 7, minute: 10, second: 17, millisecond: 158),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 69,
    Value = new TimeOnly(hour: 13, minute: 40, second: 41, millisecond: 36),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 161,
    Value = new TimeOnly(hour: 17, minute: 9, second: 55, millisecond: 356),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 11, minute: 48, second: 48, millisecond: 772),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 163,
    Value = new TimeOnly(hour: 14, minute: 25, second: 13, millisecond: 733),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 78,
    Value = new TimeOnly(hour: 15, minute: 52, second: 26, millisecond: 661),
    NullableValue = new TimeOnly(hour: 16, minute: 15, second: 38, millisecond: 510),
},
    NullableValue = new TimeOnly(hour: 18, minute: 10, second: 43, millisecond: 456),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20))]
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0mi(
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17), 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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
                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
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
    timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
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
    timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(20)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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
                List<TimeOnlytime_without_time_zone0M> models = null;

                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zone0M> models = null;

                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zone0m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @timeonlytime_without_time_zone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.TimeOnly), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(17)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(17),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "timeonlytime_without_time_zone0mi_id", 
                methodParametrName: "timeonlytime_without_time_zone0mi_id", 
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

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M), typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                ((ITimeOnlySingleTypetime_without_time_zone)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M), typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                ((ITimeOnlySingleTypetime_without_time_zone)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M), typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 2;
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 22;
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
                var models = await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[16], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[17], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[18], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[19], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M), typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionMMDynQuerySelectModelBatch(connection, 67, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 138, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[28],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
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
FROM public.timeonlytime_without_time_zone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zone0M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zone0M>();
                 ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zone0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone)),
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
                var models = await((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTSelectModelBatchAsync(connection, 116, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[9], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[10], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[11], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[12], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[13], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[14], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[15], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[16], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[17], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[18], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[19], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[29], false);
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
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSTSelectModelBatch(connection, 2, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[1], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[2], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[3], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[4], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[5], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[6], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[7], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[8], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[9], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[10], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[11], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[12], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[13], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[14], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[15], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[16], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[17], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[18], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[19], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[20], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[21], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[22], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[23], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[26],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[27],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[24], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[25], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[26], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[27], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[28], false);
                        TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((ITimeOnlySingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlySingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[6], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[7], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[8], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[9], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[10], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[11], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[12], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[29], false);
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 23, second: 40, millisecond: 834))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 21, minute: 56, second: 18, millisecond: 399))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 28, second: 44, millisecond: 247))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 2, second: 13, millisecond: 784))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 47, second: 25, millisecond: 576))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 44, second: 58, millisecond: 943))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 20, minute: 9, second: 38, millisecond: 182))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 22, second: 41, millisecond: 186))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 17, minute: 26, second: 25, millisecond: 676))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 7, minute: 0, second: 30, millisecond: 369))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 57, second: 37, millisecond: 287))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 5, second: 9, millisecond: 307))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 3, minute: 5, second: 32, millisecond: 474))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 40, second: 29, millisecond: 183))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 17, second: 42, millisecond: 281))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 46, second: 24, millisecond: 316))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 15, second: 11, millisecond: 736))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 44, second: 2, millisecond: 320))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 7, second: 43, millisecond: 514))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 2, minute: 48, second: 42, millisecond: 434))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 958))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 16, minute: 0, second: 16, millisecond: 967))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 27, second: 41, millisecond: 371))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 56, second: 18, millisecond: 474))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 49, second: 19, millisecond: 509))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 3, minute: 58, second: 44, millisecond: 474))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 9, second: 27, millisecond: 623))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 12, minute: 36, second: 4, millisecond: 130))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 27, second: 47, millisecond: 513))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 24, second: 31, millisecond: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 3, minute: 3, second: 7, millisecond: 986))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 10, minute: 28, second: 40, millisecond: 117))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 40, second: 37, millisecond: 869))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 5, second: 8, millisecond: 404))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 11, second: 5, millisecond: 210))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 57, second: 57, millisecond: 422))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 38, second: 20, millisecond: 73))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 12, second: 14, millisecond: 710))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 23, second: 57, millisecond: 984))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 46, second: 27, millisecond: 650))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 49, second: 21, millisecond: 598))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 58, second: 38, millisecond: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 53, second: 14, millisecond: 532))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 23, millisecond: 622))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 37, second: 52, millisecond: 845))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 2, second: 18, millisecond: 748))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 52, second: 33, millisecond: 415))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 46, second: 18, millisecond: 457))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 14, minute: 31, second: 20, millisecond: 105))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 44, second: 13, millisecond: 76))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 11, second: 12, millisecond: 159))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 36, second: 9, millisecond: 697))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 54, second: 52, millisecond: 366))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 772))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 38, second: 9, millisecond: 534))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 26, millisecond: 412))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 273))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 35, second: 40, millisecond: 130))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 1, minute: 18, second: 38, millisecond: 751))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 23, second: 39, millisecond: 694))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 5, second: 43, millisecond: 171))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 10, second: 17, millisecond: 158))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 13, minute: 40, second: 41, millisecond: 36))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 9, second: 55, millisecond: 356))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 11, minute: 48, second: 48, millisecond: 772))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 25, second: 13, millisecond: 733))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 15, minute: 52, second: 26, millisecond: 661))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 15, second: 38, millisecond: 510))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 18, minute: 10, second: 43, millisecond: 456))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 23, second: 40, millisecond: 834))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 21, minute: 56, second: 18, millisecond: 399))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 28, second: 44, millisecond: 247))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 2, second: 13, millisecond: 784))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 47, second: 25, millisecond: 576))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 44, second: 58, millisecond: 943))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 20, minute: 9, second: 38, millisecond: 182))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 22, second: 41, millisecond: 186))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 17, minute: 26, second: 25, millisecond: 676))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 7, minute: 0, second: 30, millisecond: 369))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 57, second: 37, millisecond: 287))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 5, second: 9, millisecond: 307))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 3, minute: 5, second: 32, millisecond: 474))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 40, second: 29, millisecond: 183))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 17, second: 42, millisecond: 281))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 46, second: 24, millisecond: 316))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 15, second: 11, millisecond: 736))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 44, second: 2, millisecond: 320))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 7, second: 43, millisecond: 514))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 2, minute: 48, second: 42, millisecond: 434))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 6, minute: 9, second: 44, millisecond: 958))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 16, minute: 0, second: 16, millisecond: 967))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 27, second: 41, millisecond: 371))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 56, second: 18, millisecond: 474))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 49, second: 19, millisecond: 509))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 3, minute: 58, second: 44, millisecond: 474))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 9, second: 27, millisecond: 623))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 12, minute: 36, second: 4, millisecond: 130))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 27, second: 47, millisecond: 513))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 24, second: 31, millisecond: 395))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 3, minute: 3, second: 7, millisecond: 986))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 10, minute: 28, second: 40, millisecond: 117))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 40, second: 37, millisecond: 869))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 5, second: 8, millisecond: 404))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 11, second: 5, millisecond: 210))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 57, second: 57, millisecond: 422))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 38, second: 20, millisecond: 73))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 12, second: 14, millisecond: 710))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 23, second: 57, millisecond: 984))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 20, minute: 46, second: 27, millisecond: 650))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 49, second: 21, millisecond: 598))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 58, second: 38, millisecond: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 7, minute: 53, second: 14, millisecond: 532))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 23, millisecond: 622))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 37, second: 52, millisecond: 845))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 2, second: 18, millisecond: 748))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 52, second: 33, millisecond: 415))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 46, second: 18, millisecond: 457))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 14, minute: 31, second: 20, millisecond: 105))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 44, second: 13, millisecond: 76))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 22, minute: 11, second: 12, millisecond: 159))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 36, second: 9, millisecond: 697))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 54, second: 52, millisecond: 366))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 18, minute: 49, second: 44, millisecond: 772))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 38, second: 9, millisecond: 534))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 26, millisecond: 412))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 9, minute: 55, second: 0, millisecond: 273))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 35, second: 40, millisecond: 130))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 1, minute: 18, second: 38, millisecond: 751))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 23, second: 39, millisecond: 694))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 5, second: 43, millisecond: 171))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 10, second: 17, millisecond: 158))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 13, minute: 40, second: 41, millisecond: 36))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 9, second: 55, millisecond: 356))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 11, minute: 48, second: 48, millisecond: 772))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 14, minute: 25, second: 13, millisecond: 733))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 15, minute: 52, second: 26, millisecond: 661))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 15, second: 38, millisecond: 510))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 18, minute: 10, second: 43, millisecond: 456))));

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
FROM public.binary_timeonlytime_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zone0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zone0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zone0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlySingleTypetime_without_time_zone)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeOnlytime_without_time_zone0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zone0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlySingleTypetime_without_time_zone)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zone0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zone0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeOnlytime_without_time_zone0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zone0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
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
FROM public.binary_timeonlytime_without_time_zone0m m
LEFT JOIN public.binary_timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zone0M>(15);

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
                ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[14], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[15], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[16], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[17], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[18], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[19], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[20], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[21], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[22], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[23], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[24], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[25], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[26],_testData[26], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[27],_testData[27], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[28],_testData[28], false);
                TimeOnlytime_without_time_zone0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zone0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zone0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(20),
                (NpgsqlTypes.NpgsqlDbType)(20)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlySingleTypetime_without_time_zone))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

