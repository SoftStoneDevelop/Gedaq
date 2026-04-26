

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
    Id = 7,
    Value = new TimeOnly(hour: 15, minute: 58, second: 52, millisecond: 29),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 9,
    Value = new TimeOnly(hour: 8, minute: 4, second: 56, millisecond: 718),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 6,
    Value = new TimeOnly(hour: 14, minute: 37, second: 15, millisecond: 889),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 11,
    Value = new TimeOnly(hour: 22, minute: 12, second: 51, millisecond: 326),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 1, minute: 18, second: 15, millisecond: 928),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 19,
    Value = new TimeOnly(hour: 17, minute: 19, second: 4, millisecond: 109),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 7,
    Value = new TimeOnly(hour: 9, minute: 58, second: 24, millisecond: 61),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 20,
    Value = new TimeOnly(hour: 8, minute: 29, second: 46, millisecond: 855),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 25,
    Value = new TimeOnly(hour: 19, minute: 12, second: 45, millisecond: 156),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 16,
    Value = new TimeOnly(hour: 11, minute: 34, second: 34, millisecond: 696),
    NullableValue = new TimeOnly(hour: 8, minute: 26, second: 39, millisecond: 143),
},
    NullableValue = new TimeOnly(hour: 1, minute: 11, second: 19, millisecond: 362),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 33,
    Value = new TimeOnly(hour: 1, minute: 47, second: 33, millisecond: 877),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 38,
    Value = new TimeOnly(hour: 13, minute: 4, second: 37, millisecond: 335),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 20,
    Value = new TimeOnly(hour: 9, minute: 24, second: 30, millisecond: 104),
    NullableValue = new TimeOnly(hour: 19, minute: 5, second: 46, millisecond: 875),
},
    NullableValue = new TimeOnly(hour: 12, minute: 48, second: 33, millisecond: 843),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 43,
    Value = new TimeOnly(hour: 3, minute: 13, second: 49, millisecond: 910),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 5, minute: 34, second: 47, millisecond: 809),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 44,
    Value = new TimeOnly(hour: 5, minute: 8, second: 1, millisecond: 838),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 28,
    Value = new TimeOnly(hour: 8, minute: 5, second: 22, millisecond: 142),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 52,
    Value = new TimeOnly(hour: 5, minute: 51, second: 10, millisecond: 683),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 58,
    Value = new TimeOnly(hour: 20, minute: 30, second: 33, millisecond: 921),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 33,
    Value = new TimeOnly(hour: 11, minute: 55, second: 35, millisecond: 366),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 67,
    Value = new TimeOnly(hour: 11, minute: 7, second: 36, millisecond: 263),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 6, minute: 2, second: 56, millisecond: 165),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 76,
    Value = new TimeOnly(hour: 5, minute: 10, second: 7, millisecond: 809),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 38,
    Value = new TimeOnly(hour: 11, minute: 55, second: 51, millisecond: 835),
    NullableValue = new TimeOnly(hour: 22, minute: 48, second: 37, millisecond: 296),
},
    NullableValue = new TimeOnly(hour: 4, minute: 10, second: 30, millisecond: 10),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 82,
    Value = new TimeOnly(hour: 5, minute: 58, second: 2, millisecond: 195),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 83,
    Value = new TimeOnly(hour: 22, minute: 55, second: 22, millisecond: 190),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 45,
    Value = new TimeOnly(hour: 18, minute: 31, second: 27, millisecond: 156),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 87,
    Value = new TimeOnly(hour: 4, minute: 19, second: 37, millisecond: 872),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 95,
    Value = new TimeOnly(hour: 9, minute: 37, second: 8, millisecond: 543),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 47,
    Value = new TimeOnly(hour: 11, minute: 46, second: 35, millisecond: 214),
    NullableValue = null,
},
    NullableValue = new TimeOnly(hour: 21, minute: 25, second: 53, millisecond: 672),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 98,
    Value = new TimeOnly(hour: 19, minute: 24, second: 38, millisecond: 468),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 107,
    Value = new TimeOnly(hour: 4, minute: 48, second: 47, millisecond: 787),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 48,
    Value = new TimeOnly(hour: 2, minute: 8, second: 10, millisecond: 740),
    NullableValue = new TimeOnly(hour: 6, minute: 3, second: 40, millisecond: 717),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 108,
    Value = new TimeOnly(hour: 18, minute: 2, second: 49, millisecond: 623),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 2, minute: 21, second: 26, millisecond: 875),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 116,
    Value = new TimeOnly(hour: 4, minute: 2, second: 7, millisecond: 113),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 50,
    Value = new TimeOnly(hour: 11, minute: 17, second: 14, millisecond: 734),
    NullableValue = new TimeOnly(hour: 0, minute: 51, second: 15, millisecond: 988),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 125,
    Value = new TimeOnly(hour: 0, minute: 27, second: 30, millisecond: 939),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 127,
    Value = new TimeOnly(hour: 7, minute: 10, second: 53, millisecond: 957),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 56,
    Value = new TimeOnly(hour: 22, minute: 49, second: 47, millisecond: 270),
    NullableValue = new TimeOnly(hour: 7, minute: 6, second: 14, millisecond: 147),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 133,
    Value = new TimeOnly(hour: 3, minute: 26, second: 39, millisecond: 253),
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 138,
    Value = new TimeOnly(hour: 15, minute: 9, second: 9, millisecond: 3),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 64,
    Value = new TimeOnly(hour: 22, minute: 26, second: 29, millisecond: 614),
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 142,
    Value = new TimeOnly(hour: 9, minute: 20, second: 19, millisecond: 143),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 4, minute: 25, second: 5, millisecond: 226),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 144,
    Value = new TimeOnly(hour: 17, minute: 21, second: 5, millisecond: 369),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 70,
    Value = new TimeOnly(hour: 3, minute: 55, second: 38, millisecond: 574),
    NullableValue = new TimeOnly(hour: 16, minute: 51, second: 28, millisecond: 770),
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 151,
    Value = new TimeOnly(hour: 20, minute: 3, second: 15, millisecond: 376),
    ModelInner = null,
    NullableValue = new TimeOnly(hour: 15, minute: 52, second: 13, millisecond: 341),
},
            new TimeOnlytime_without_time_zone0M
{
    Id = 156,
    Value = new TimeOnly(hour: 17, minute: 23, second: 55, millisecond: 771),
    ModelInner = new TimeOnlytime_without_time_zone0MI
{
    Id = 75,
    Value = new TimeOnly(hour: 2, minute: 22, second: 21, millisecond: 11),
    NullableValue = null,
},
    NullableValue = null,
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
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
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[7], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[8], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[9], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[10], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[11], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[12], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[13], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[5], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[6], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[7], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[8], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[9], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[10], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[11], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[12], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[13], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[10], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[11], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[12], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[13], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[1], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[2], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[3], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[4], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[5], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[6], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[7], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[8], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[9], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[10], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[11], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[12], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[26],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[27],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[29], false);
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

                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zone0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[13], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zone0m m
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
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
LEFT JOIN public.timeonlytime_without_time_zone0mi mi ON mi.id = m.timeonlytime_without_time_zone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[1], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[2], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[3], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[4], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[5], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[6], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[7], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[8], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[9], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[10], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[11], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[12], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[13], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[14], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[15], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[16], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[17], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[18], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[26],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[27],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[19], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[20], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[21], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[22], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[23], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[24], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[25], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[26], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[27], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[28], false);FlatTimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelBatchAsync(connection, 19, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[4], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[5], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[6], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[7], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[8], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[9], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[10], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[11], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[12], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[23],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[24],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[29], false);
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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zone0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelBatch(connection, 133, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[29], false);
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
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[9], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[10], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[11], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[12], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlySingleTypetime_without_time_zone)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlySingleTypetime_without_time_zone)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeOnlytime_without_time_zone0M.AssertModel(models[0],_testData[7], false);TimeOnlytime_without_time_zone0M.AssertModel(models[1],_testData[8], false);TimeOnlytime_without_time_zone0M.AssertModel(models[2],_testData[9], false);TimeOnlytime_without_time_zone0M.AssertModel(models[3],_testData[10], false);TimeOnlytime_without_time_zone0M.AssertModel(models[4],_testData[11], false);TimeOnlytime_without_time_zone0M.AssertModel(models[5],_testData[12], false);TimeOnlytime_without_time_zone0M.AssertModel(models[6],_testData[13], false);TimeOnlytime_without_time_zone0M.AssertModel(models[7],_testData[14], false);TimeOnlytime_without_time_zone0M.AssertModel(models[8],_testData[15], false);TimeOnlytime_without_time_zone0M.AssertModel(models[9],_testData[16], false);TimeOnlytime_without_time_zone0M.AssertModel(models[10],_testData[17], false);TimeOnlytime_without_time_zone0M.AssertModel(models[11],_testData[18], false);TimeOnlytime_without_time_zone0M.AssertModel(models[12],_testData[19], false);TimeOnlytime_without_time_zone0M.AssertModel(models[13],_testData[20], false);TimeOnlytime_without_time_zone0M.AssertModel(models[14],_testData[21], false);TimeOnlytime_without_time_zone0M.AssertModel(models[15],_testData[22], false);TimeOnlytime_without_time_zone0M.AssertModel(models[16],_testData[23], false);TimeOnlytime_without_time_zone0M.AssertModel(models[17],_testData[24], false);TimeOnlytime_without_time_zone0M.AssertModel(models[18],_testData[25], false);TimeOnlytime_without_time_zone0M.AssertModel(models[19],_testData[26], false);TimeOnlytime_without_time_zone0M.AssertModel(models[20],_testData[27], false);TimeOnlytime_without_time_zone0M.AssertModel(models[21],_testData[28], false);TimeOnlytime_without_time_zone0M.AssertModel(models[22],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 58, second: 52, millisecond: 29))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 4, second: 56, millisecond: 718))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 14, minute: 37, second: 15, millisecond: 889))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 12, second: 51, millisecond: 326))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 18, second: 15, millisecond: 928))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 19, second: 4, millisecond: 109))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 58, second: 24, millisecond: 61))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 29, second: 46, millisecond: 855))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 19, minute: 12, second: 45, millisecond: 156))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 34, second: 34, millisecond: 696))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 26, second: 39, millisecond: 143))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 11, second: 19, millisecond: 362))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 1, minute: 47, second: 33, millisecond: 877))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 4, second: 37, millisecond: 335))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 24, second: 30, millisecond: 104))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 19, minute: 5, second: 46, millisecond: 875))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 48, second: 33, millisecond: 843))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 13, second: 49, millisecond: 910))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 5, minute: 34, second: 47, millisecond: 809))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 1, millisecond: 838))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 5, second: 22, millisecond: 142))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 51, second: 10, millisecond: 683))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 30, second: 33, millisecond: 921))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 55, second: 35, millisecond: 366))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 7, second: 36, millisecond: 263))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 2, second: 56, millisecond: 165))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 10, second: 7, millisecond: 809))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 55, second: 51, millisecond: 835))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 48, second: 37, millisecond: 296))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 10, second: 30, millisecond: 10))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 58, second: 2, millisecond: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 55, second: 22, millisecond: 190))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 31, second: 27, millisecond: 156))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 19, second: 37, millisecond: 872))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 37, second: 8, millisecond: 543))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 46, second: 35, millisecond: 214))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 21, minute: 25, second: 53, millisecond: 672))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 19, minute: 24, second: 38, millisecond: 468))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 48, second: 47, millisecond: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 8, second: 10, millisecond: 740))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 6, minute: 3, second: 40, millisecond: 717))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 2, second: 49, millisecond: 623))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 2, minute: 21, second: 26, millisecond: 875))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 2, second: 7, millisecond: 113))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 17, second: 14, millisecond: 734))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 0, minute: 51, second: 15, millisecond: 988))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 27, second: 30, millisecond: 939))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 10, second: 53, millisecond: 957))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 49, second: 47, millisecond: 270))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 7, minute: 6, second: 14, millisecond: 147))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 26, second: 39, millisecond: 253))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 9, second: 9, millisecond: 3))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 26, second: 29, millisecond: 614))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 20, second: 19, millisecond: 143))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 25, second: 5, millisecond: 226))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 21, second: 5, millisecond: 369))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 3, minute: 55, second: 38, millisecond: 574))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 51, second: 28, millisecond: 770))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 3, second: 15, millisecond: 376))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 52, second: 13, millisecond: 341))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 23, second: 55, millisecond: 771))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 22, second: 21, millisecond: 11))));//InnerModel.Value

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
                var models =  ((ITimeOnlySingleTypetime_without_time_zone)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 58, second: 52, millisecond: 29))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 4, second: 56, millisecond: 718))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 14, minute: 37, second: 15, millisecond: 889))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 12, second: 51, millisecond: 326))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 18, second: 15, millisecond: 928))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 19, second: 4, millisecond: 109))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 58, second: 24, millisecond: 61))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 8, minute: 29, second: 46, millisecond: 855))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 19, minute: 12, second: 45, millisecond: 156))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 34, second: 34, millisecond: 696))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 8, minute: 26, second: 39, millisecond: 143))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 1, minute: 11, second: 19, millisecond: 362))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 1, minute: 47, second: 33, millisecond: 877))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 13, minute: 4, second: 37, millisecond: 335))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 9, minute: 24, second: 30, millisecond: 104))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 19, minute: 5, second: 46, millisecond: 875))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 12, minute: 48, second: 33, millisecond: 843))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 13, second: 49, millisecond: 910))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 5, minute: 34, second: 47, millisecond: 809))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 8, second: 1, millisecond: 838))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 8, minute: 5, second: 22, millisecond: 142))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 51, second: 10, millisecond: 683))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 30, second: 33, millisecond: 921))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 55, second: 35, millisecond: 366))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 11, minute: 7, second: 36, millisecond: 263))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 6, minute: 2, second: 56, millisecond: 165))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 10, second: 7, millisecond: 809))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 55, second: 51, millisecond: 835))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 22, minute: 48, second: 37, millisecond: 296))));//InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 10, second: 30, millisecond: 10))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 5, minute: 58, second: 2, millisecond: 195))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 22, minute: 55, second: 22, millisecond: 190))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 18, minute: 31, second: 27, millisecond: 156))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 19, second: 37, millisecond: 872))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 37, second: 8, millisecond: 543))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 46, second: 35, millisecond: 214))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 21, minute: 25, second: 53, millisecond: 672))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 19, minute: 24, second: 38, millisecond: 468))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 48, second: 47, millisecond: 787))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 8, second: 10, millisecond: 740))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 6, minute: 3, second: 40, millisecond: 717))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 18, minute: 2, second: 49, millisecond: 623))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 2, minute: 21, second: 26, millisecond: 875))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 4, minute: 2, second: 7, millisecond: 113))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 11, minute: 17, second: 14, millisecond: 734))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 0, minute: 51, second: 15, millisecond: 988))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 0, minute: 27, second: 30, millisecond: 939))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 7, minute: 10, second: 53, millisecond: 957))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 49, second: 47, millisecond: 270))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 7, minute: 6, second: 14, millisecond: 147))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 3, minute: 26, second: 39, millisecond: 253))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 15, minute: 9, second: 9, millisecond: 3))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 22, minute: 26, second: 29, millisecond: 614))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 9, minute: 20, second: 19, millisecond: 143))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 4, minute: 25, second: 5, millisecond: 226))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 21, second: 5, millisecond: 369))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 3, minute: 55, second: 38, millisecond: 574))));//InnerModel.Value

                Assert.That((System.TimeOnly?)model[4], Is.EqualTo((new TimeOnly(hour: 16, minute: 51, second: 28, millisecond: 770))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 20, minute: 3, second: 15, millisecond: 376))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.TimeOnly?)model[5], Is.EqualTo((new TimeOnly(hour: 15, minute: 52, second: 13, millisecond: 341))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.TimeOnly)model[1], Is.EqualTo((new TimeOnly(hour: 17, minute: 23, second: 55, millisecond: 771))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.TimeOnly)model[3], Is.EqualTo((new TimeOnly(hour: 2, minute: 22, second: 21, millisecond: 11))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zone0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(actual, expect, false);
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
                await ((ITimeOnlySingleTypetime_without_time_zone)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeOnlySingleTypetime_without_time_zone)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zone0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

