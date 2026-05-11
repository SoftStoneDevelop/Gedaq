

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


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

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 1,
    Value = 1349118882488253776L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 8,
    Value = 6586814139691377084L,
    ModelInner = new Int64bigintE0MI
{
    Id = 9,
    Value = 3717159727416766000L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 15,
    Value = 63488895446391284L,
    ModelInner = null,
    NullableValue = 6152538847745069339L,
},
            new Int64bigintE0M
{
    Id = 24,
    Value = 4315901073271397785L,
    ModelInner = new Int64bigintE0MI
{
    Id = 17,
    Value = 6031003857746372783L,
    NullableValue = 3901056126198477237L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 31,
    Value = 6623095875274291527L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 40,
    Value = 2289344882780407986L,
    ModelInner = new Int64bigintE0MI
{
    Id = 20,
    Value = 8774352189059174247L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 46,
    Value = 2230380938763531140L,
    ModelInner = null,
    NullableValue = 8095428715361979542L,
},
            new Int64bigintE0M
{
    Id = 54,
    Value = 2883873827207720017L,
    ModelInner = new Int64bigintE0MI
{
    Id = 25,
    Value = 967867324473817313L,
    NullableValue = 7990214660440286966L,
},
    NullableValue = 9109174125310497064L,
},
            new Int64bigintE0M
{
    Id = 59,
    Value = 2043532999459054095L,
    ModelInner = null,
    NullableValue = 8228305991944604050L,
},
            new Int64bigintE0M
{
    Id = 65,
    Value = 6159039784927679610L,
    ModelInner = new Int64bigintE0MI
{
    Id = 33,
    Value = 5175856056347675168L,
    NullableValue = null,
},
    NullableValue = 4389284592284480947L,
},
            new Int64bigintE0M
{
    Id = 72,
    Value = 5900558567460911880L,
    ModelInner = null,
    NullableValue = 6465093345075185172L,
},
            new Int64bigintE0M
{
    Id = 77,
    Value = 4010420508178945033L,
    ModelInner = new Int64bigintE0MI
{
    Id = 37,
    Value = 6993706647475199434L,
    NullableValue = 6920396620200485133L,
},
    NullableValue = 7445806202191243580L,
},
            new Int64bigintE0M
{
    Id = 82,
    Value = 6220373646870680704L,
    ModelInner = null,
    NullableValue = 3282808276340890194L,
},
            new Int64bigintE0M
{
    Id = 89,
    Value = 8541783843796416885L,
    ModelInner = new Int64bigintE0MI
{
    Id = 40,
    Value = 5681892117030488937L,
    NullableValue = 7753607782436070183L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 91,
    Value = 485702302828475276L,
    ModelInner = null,
    NullableValue = 9215402000646736358L,
},
            new Int64bigintE0M
{
    Id = 92,
    Value = 3955499690523209629L,
    ModelInner = new Int64bigintE0MI
{
    Id = 43,
    Value = 8165372057299033098L,
    NullableValue = null,
},
    NullableValue = 6510139596175602544L,
},
            new Int64bigintE0M
{
    Id = 93,
    Value = 9202115261405322559L,
    ModelInner = null,
    NullableValue = 7791887748067742054L,
},
            new Int64bigintE0M
{
    Id = 99,
    Value = 3489184764288773944L,
    ModelInner = new Int64bigintE0MI
{
    Id = 46,
    Value = 7939297144958566196L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 104,
    Value = 3929246127335713589L,
    ModelInner = null,
    NullableValue = 4377877677417668225L,
},
            new Int64bigintE0M
{
    Id = 109,
    Value = 3839388741231733919L,
    ModelInner = new Int64bigintE0MI
{
    Id = 47,
    Value = 2971492462393435599L,
    NullableValue = null,
},
    NullableValue = 8138599000177588624L,
},
            new Int64bigintE0M
{
    Id = 115,
    Value = 5987050058778882996L,
    ModelInner = null,
    NullableValue = 7601355693482828986L,
},
            new Int64bigintE0M
{
    Id = 118,
    Value = 7124812732253995313L,
    ModelInner = new Int64bigintE0MI
{
    Id = 48,
    Value = 117079036670937855L,
    NullableValue = null,
},
    NullableValue = 4928120119182925037L,
},
            new Int64bigintE0M
{
    Id = 123,
    Value = 2004136294025214109L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 131,
    Value = 6835435793291198921L,
    ModelInner = new Int64bigintE0MI
{
    Id = 52,
    Value = 4420483032465516502L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 137,
    Value = 8758066955051056827L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 144,
    Value = 7144382651939675416L,
    ModelInner = new Int64bigintE0MI
{
    Id = 56,
    Value = 1643491533716149346L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 153,
    Value = 8557336823625728287L,
    ModelInner = null,
    NullableValue = 8257767471717701872L,
},
            new Int64bigintE0M
{
    Id = 158,
    Value = 1362151819029271676L,
    ModelInner = new Int64bigintE0MI
{
    Id = 61,
    Value = 4179375328912223180L,
    NullableValue = null,
},
    NullableValue = 1403231555854280742L,
},
            new Int64bigintE0M
{
    Id = 163,
    Value = 4221691861833070511L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 165,
    Value = 8026217397062712511L,
    ModelInner = new Int64bigintE0MI
{
    Id = 65,
    Value = 7113411741167750122L,
    NullableValue = 1941981905394716796L,
},
    NullableValue = 1100708652845451725L,
},
            new Int64bigintE0M
{
    Id = 171,
    Value = 9101128231990250177L,
    ModelInner = null,
    NullableValue = 8360033567656269230L,
},
            new Int64bigintE0M
{
    Id = 173,
    Value = 7327674556050417522L,
    ModelInner = new Int64bigintE0MI
{
    Id = 68,
    Value = 36603226949891442L,
    NullableValue = 321681954714922808L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 180,
    Value = 3720157675602619324L,
    ModelInner = null,
    NullableValue = 8999573407132107924L,
},
            new Int64bigintE0M
{
    Id = 188,
    Value = 1750765719529561243L,
    ModelInner = new Int64bigintE0MI
{
    Id = 74,
    Value = 3457284303332002007L,
    NullableValue = 490345917197890504L,
},
    NullableValue = 1513601325980019093L,
},
            new Int64bigintE0M
{
    Id = 196,
    Value = 4700031628302883832L,
    ModelInner = null,
    NullableValue = 5564660663513193411L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(8))]
        public void InsertModelInnerConfig()
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

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0mi(
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(8),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true)]
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

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
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
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 171;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintE0M.AssertModel(models[0],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintE0M.AssertModel(models[0],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintE0M.AssertModel(models[0],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintE0M.AssertModel(models[0],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 180, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 115, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 82, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 171, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintE0M.AssertModel(models[0],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintE0M.AssertModel(models[0],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 31, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintE0M.AssertModel(models[0],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintE0M.AssertModel(models[0],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Int64bigintE0M.AssertModel(models[0],_testData[11], false);
                Int64bigintE0M.AssertModel(models[1],_testData[12], false);
                Int64bigintE0M.AssertModel(models[2],_testData[13], false);
                Int64bigintE0M.AssertModel(models[3],_testData[14], false);
                Int64bigintE0M.AssertModel(models[4],_testData[15], false);
                Int64bigintE0M.AssertModel(models[5],_testData[16], false);
                Int64bigintE0M.AssertModel(models[6],_testData[17], false);
                Int64bigintE0M.AssertModel(models[7],_testData[18], false);
                Int64bigintE0M.AssertModel(models[8],_testData[19], false);
                Int64bigintE0M.AssertModel(models[9],_testData[20], false);
                Int64bigintE0M.AssertModel(models[10],_testData[21], false);
                Int64bigintE0M.AssertModel(models[11],_testData[22], false);
                Int64bigintE0M.AssertModel(models[12],_testData[23], false);
                Int64bigintE0M.AssertModel(models[13],_testData[24], false);
                Int64bigintE0M.AssertModel(models[14],_testData[25], false);
                Int64bigintE0M.AssertModel(models[15],_testData[26], false);
                Int64bigintE0M.AssertModel(models[16],_testData[27], false);
                Int64bigintE0M.AssertModel(models[17],_testData[28], false);
                Int64bigintE0M.AssertModel(models[18],_testData[29], false);
                Int64bigintE0M.AssertModel(models[19],_testData[30], false);
                Int64bigintE0M.AssertModel(models[20],_testData[31], false);
                Int64bigintE0M.AssertModel(models[21],_testData[32], false);
                Int64bigintE0M.AssertModel(models[22],_testData[33], false);
                Int64bigintE0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintE0M.AssertModel(models[0],_testData[20], false);
                Int64bigintE0M.AssertModel(models[1],_testData[21], false);
                Int64bigintE0M.AssertModel(models[2],_testData[22], false);
                Int64bigintE0M.AssertModel(models[3],_testData[23], false);
                Int64bigintE0M.AssertModel(models[4],_testData[24], false);
                Int64bigintE0M.AssertModel(models[5],_testData[25], false);
                Int64bigintE0M.AssertModel(models[6],_testData[26], false);
                Int64bigintE0M.AssertModel(models[7],_testData[27], false);
                Int64bigintE0M.AssertModel(models[8],_testData[28], false);
                Int64bigintE0M.AssertModel(models[9],_testData[29], false);
                Int64bigintE0M.AssertModel(models[10],_testData[30], false);
                Int64bigintE0M.AssertModel(models[11],_testData[31], false);
                Int64bigintE0M.AssertModel(models[12],_testData[32], false);
                Int64bigintE0M.AssertModel(models[13],_testData[33], false);
                Int64bigintE0M.AssertModel(models[14],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1349118882488253776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6586814139691377084L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3717159727416766000L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((63488895446391284L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6152538847745069339L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4315901073271397785L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6031003857746372783L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3901056126198477237L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6623095875274291527L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2289344882780407986L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8774352189059174247L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2230380938763531140L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8095428715361979542L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2883873827207720017L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((967867324473817313L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7990214660440286966L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9109174125310497064L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2043532999459054095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8228305991944604050L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6159039784927679610L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5175856056347675168L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4389284592284480947L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5900558567460911880L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6465093345075185172L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4010420508178945033L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6993706647475199434L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6920396620200485133L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7445806202191243580L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6220373646870680704L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3282808276340890194L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8541783843796416885L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5681892117030488937L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7753607782436070183L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((485702302828475276L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9215402000646736358L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3955499690523209629L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8165372057299033098L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6510139596175602544L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9202115261405322559L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7791887748067742054L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3489184764288773944L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7939297144958566196L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3929246127335713589L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4377877677417668225L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3839388741231733919L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2971492462393435599L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8138599000177588624L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5987050058778882996L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7601355693482828986L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7124812732253995313L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((117079036670937855L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4928120119182925037L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2004136294025214109L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6835435793291198921L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4420483032465516502L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8758066955051056827L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7144382651939675416L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1643491533716149346L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8557336823625728287L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8257767471717701872L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1362151819029271676L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4179375328912223180L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1403231555854280742L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4221691861833070511L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8026217397062712511L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7113411741167750122L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1941981905394716796L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1100708652845451725L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9101128231990250177L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8360033567656269230L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7327674556050417522L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((36603226949891442L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((321681954714922808L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3720157675602619324L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8999573407132107924L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1750765719529561243L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3457284303332002007L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((490345917197890504L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1513601325980019093L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4700031628302883832L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5564660663513193411L)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1349118882488253776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6586814139691377084L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3717159727416766000L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((63488895446391284L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6152538847745069339L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4315901073271397785L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6031003857746372783L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3901056126198477237L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6623095875274291527L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2289344882780407986L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8774352189059174247L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2230380938763531140L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8095428715361979542L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2883873827207720017L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((967867324473817313L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7990214660440286966L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9109174125310497064L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2043532999459054095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8228305991944604050L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6159039784927679610L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5175856056347675168L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4389284592284480947L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5900558567460911880L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6465093345075185172L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4010420508178945033L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6993706647475199434L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6920396620200485133L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7445806202191243580L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6220373646870680704L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3282808276340890194L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8541783843796416885L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5681892117030488937L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7753607782436070183L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((485702302828475276L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9215402000646736358L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3955499690523209629L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8165372057299033098L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6510139596175602544L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9202115261405322559L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7791887748067742054L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3489184764288773944L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7939297144958566196L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3929246127335713589L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4377877677417668225L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3839388741231733919L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2971492462393435599L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8138599000177588624L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5987050058778882996L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7601355693482828986L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7124812732253995313L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((117079036670937855L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4928120119182925037L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2004136294025214109L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6835435793291198921L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4420483032465516502L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8758066955051056827L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7144382651939675416L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1643491533716149346L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8557336823625728287L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8257767471717701872L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1362151819029271676L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4179375328912223180L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1403231555854280742L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4221691861833070511L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8026217397062712511L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7113411741167750122L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1941981905394716796L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1100708652845451725L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9101128231990250177L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8360033567656269230L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7327674556050417522L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((36603226949891442L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((321681954714922808L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3720157675602619324L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8999573407132107924L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1750765719529561243L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3457284303332002007L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((490345917197890504L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1513601325980019093L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4700031628302883832L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5564660663513193411L)));

            }
        }

#endregion

    }
}

