

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
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

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 9,
    Value = 8297870718703398594L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 18,
    Value = 1749809987207899372L,
    ModelInner = new Int64bigintE0MI
{
    Id = 8,
    Value = 2742911455840065981L,
    NullableValue = 2875337292000472635L,
},
    NullableValue = 2493074276700818023L,
},
            new Int64bigintE0M
{
    Id = 22,
    Value = 2940075959280837079L,
    ModelInner = null,
    NullableValue = 3025916692875732278L,
},
            new Int64bigintE0M
{
    Id = 24,
    Value = 5252558250993592707L,
    ModelInner = new Int64bigintE0MI
{
    Id = 13,
    Value = 7761994901628650897L,
    NullableValue = null,
},
    NullableValue = 6627321673426816564L,
},
            new Int64bigintE0M
{
    Id = 27,
    Value = 2824680298332923984L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 32,
    Value = 1640741163421738396L,
    ModelInner = new Int64bigintE0MI
{
    Id = 19,
    Value = 4590620089247848315L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 35,
    Value = 6875194385131364482L,
    ModelInner = null,
    NullableValue = 8987966230206559711L,
},
            new Int64bigintE0M
{
    Id = 36,
    Value = 2001349187168548124L,
    ModelInner = new Int64bigintE0MI
{
    Id = 28,
    Value = 1440056467417187641L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 37,
    Value = 2080943180578953448L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 46,
    Value = 558140072882767585L,
    ModelInner = new Int64bigintE0MI
{
    Id = 36,
    Value = 4790933420235738378L,
    NullableValue = 825070459594532123L,
},
    NullableValue = 4220672880129868526L,
},
            new Int64bigintE0M
{
    Id = 52,
    Value = 3716263430087632916L,
    ModelInner = null,
    NullableValue = 2818603773782987600L,
},
            new Int64bigintE0M
{
    Id = 59,
    Value = 5465425656567620901L,
    ModelInner = new Int64bigintE0MI
{
    Id = 38,
    Value = 4428981993766056387L,
    NullableValue = 731873220707233644L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 62,
    Value = 7908963909977520610L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 63,
    Value = 2660411488798364942L,
    ModelInner = new Int64bigintE0MI
{
    Id = 44,
    Value = 5379895146087216739L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 72,
    Value = 6298098561793821898L,
    ModelInner = null,
    NullableValue = 2476730285186990795L,
},
            new Int64bigintE0M
{
    Id = 75,
    Value = 3026134525435997214L,
    ModelInner = new Int64bigintE0MI
{
    Id = 49,
    Value = 77669112291107883L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 77,
    Value = 8384990712818997693L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 84,
    Value = 3628077860828676653L,
    ModelInner = new Int64bigintE0MI
{
    Id = 53,
    Value = 5806499143310841463L,
    NullableValue = 3694280363945838175L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 7037595474061418532L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 92,
    Value = 5104647645415963032L,
    ModelInner = new Int64bigintE0MI
{
    Id = 60,
    Value = 5834453749914921511L,
    NullableValue = null,
},
    NullableValue = 9021852997057578478L,
},
            new Int64bigintE0M
{
    Id = 98,
    Value = 5379991909170133845L,
    ModelInner = null,
    NullableValue = 8882436093598369077L,
},
            new Int64bigintE0M
{
    Id = 101,
    Value = 7907085868194142644L,
    ModelInner = new Int64bigintE0MI
{
    Id = 65,
    Value = 8147043930342797939L,
    NullableValue = 568793734075291268L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 104,
    Value = 3081766617534296776L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 111,
    Value = 2128594188661117312L,
    ModelInner = new Int64bigintE0MI
{
    Id = 70,
    Value = 6760017640122824803L,
    NullableValue = 7289192064159120967L,
},
    NullableValue = 2638249903379276302L,
},
            new Int64bigintE0M
{
    Id = 113,
    Value = 5228535026163225411L,
    ModelInner = null,
    NullableValue = 48803224257945924L,
},
            new Int64bigintE0M
{
    Id = 119,
    Value = 8765814060134030635L,
    ModelInner = new Int64bigintE0MI
{
    Id = 71,
    Value = 407239961434994885L,
    NullableValue = 7332596847993943801L,
},
    NullableValue = 6909298376878134226L,
},
            new Int64bigintE0M
{
    Id = 127,
    Value = 2453047558768856136L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 128,
    Value = 6205965132389167866L,
    ModelInner = new Int64bigintE0MI
{
    Id = 75,
    Value = 7075049246598976188L,
    NullableValue = null,
},
    NullableValue = 5309747519125515418L,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 1834788669076945702L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 143,
    Value = 7779226874761754045L,
    ModelInner = new Int64bigintE0MI
{
    Id = 82,
    Value = 2034265582630054542L,
    NullableValue = 2956623885848673678L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 151,
    Value = 6110066126148439115L,
    ModelInner = null,
    NullableValue = 4110620948480813251L,
},
            new Int64bigintE0M
{
    Id = 154,
    Value = 1923153959972981417L,
    ModelInner = new Int64bigintE0MI
{
    Id = 90,
    Value = 1332681976860787514L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 155,
    Value = 3813566356433486464L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 160,
    Value = 8237288783946100024L,
    ModelInner = new Int64bigintE0MI
{
    Id = 95,
    Value = 3299521009744444325L,
    NullableValue = 7662539468974110657L,
},
    NullableValue = 8879034841642360270L,
},
            new Int64bigintE0M
{
    Id = 162,
    Value = 3518145485861964812L,
    ModelInner = null,
    NullableValue = 7946830766455268956L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(0))
            ]
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
INSERT INTO dbo.int64biginte0mi(
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
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12, 
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

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(0),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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
INSERT INTO dbo.int64biginte0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
                dbType: (System.Data.DbType)11,
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[31],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 62;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 111;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintE0M.AssertModel(models[0],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintE0M.AssertModel(models[0],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int64bigintE0M.AssertModel(models[0],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[34], false);
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 98, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[34], false);
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 52, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 27, query2))
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
            dbType: (System.Data.DbType)11)]
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int64bigintE0M.AssertModel(models[0],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintE0M.AssertModel(models[0],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 92, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintE0M.AssertModel(models[0],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Int64bigintE0M.AssertModel(models[0],_testData[10], false);
                Int64bigintE0M.AssertModel(models[1],_testData[11], false);
                Int64bigintE0M.AssertModel(models[2],_testData[12], false);
                Int64bigintE0M.AssertModel(models[3],_testData[13], false);
                Int64bigintE0M.AssertModel(models[4],_testData[14], false);
                Int64bigintE0M.AssertModel(models[5],_testData[15], false);
                Int64bigintE0M.AssertModel(models[6],_testData[16], false);
                Int64bigintE0M.AssertModel(models[7],_testData[17], false);
                Int64bigintE0M.AssertModel(models[8],_testData[18], false);
                Int64bigintE0M.AssertModel(models[9],_testData[19], false);
                Int64bigintE0M.AssertModel(models[10],_testData[20], false);
                Int64bigintE0M.AssertModel(models[11],_testData[21], false);
                Int64bigintE0M.AssertModel(models[12],_testData[22], false);
                Int64bigintE0M.AssertModel(models[13],_testData[23], false);
                Int64bigintE0M.AssertModel(models[14],_testData[24], false);
                Int64bigintE0M.AssertModel(models[15],_testData[25], false);
                Int64bigintE0M.AssertModel(models[16],_testData[26], false);
                Int64bigintE0M.AssertModel(models[17],_testData[27], false);
                Int64bigintE0M.AssertModel(models[18],_testData[28], false);
                Int64bigintE0M.AssertModel(models[19],_testData[29], false);
                Int64bigintE0M.AssertModel(models[20],_testData[30], false);
                Int64bigintE0M.AssertModel(models[21],_testData[31], false);
                Int64bigintE0M.AssertModel(models[22],_testData[32], false);
                Int64bigintE0M.AssertModel(models[23],_testData[33], false);
                Int64bigintE0M.AssertModel(models[24],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8297870718703398594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1749809987207899372L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2742911455840065981L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2875337292000472635L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2493074276700818023L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2940075959280837079L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3025916692875732278L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5252558250993592707L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7761994901628650897L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6627321673426816564L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2824680298332923984L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1640741163421738396L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4590620089247848315L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6875194385131364482L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8987966230206559711L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2001349187168548124L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1440056467417187641L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2080943180578953448L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((558140072882767585L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4790933420235738378L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((825070459594532123L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4220672880129868526L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3716263430087632916L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2818603773782987600L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5465425656567620901L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4428981993766056387L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((731873220707233644L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7908963909977520610L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2660411488798364942L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5379895146087216739L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6298098561793821898L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2476730285186990795L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3026134525435997214L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((77669112291107883L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8384990712818997693L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3628077860828676653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5806499143310841463L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3694280363945838175L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7037595474061418532L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5104647645415963032L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5834453749914921511L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9021852997057578478L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5379991909170133845L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8882436093598369077L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7907085868194142644L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8147043930342797939L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((568793734075291268L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3081766617534296776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2128594188661117312L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6760017640122824803L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7289192064159120967L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2638249903379276302L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5228535026163225411L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((48803224257945924L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8765814060134030635L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((407239961434994885L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7332596847993943801L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6909298376878134226L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2453047558768856136L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6205965132389167866L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7075049246598976188L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5309747519125515418L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1834788669076945702L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7779226874761754045L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2034265582630054542L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2956623885848673678L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6110066126148439115L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4110620948480813251L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1923153959972981417L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1332681976860787514L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3813566356433486464L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8237288783946100024L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3299521009744444325L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7662539468974110657L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8879034841642360270L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3518145485861964812L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7946830766455268956L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8297870718703398594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1749809987207899372L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2742911455840065981L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2875337292000472635L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2493074276700818023L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2940075959280837079L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3025916692875732278L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5252558250993592707L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7761994901628650897L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6627321673426816564L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2824680298332923984L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1640741163421738396L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4590620089247848315L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6875194385131364482L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8987966230206559711L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2001349187168548124L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1440056467417187641L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2080943180578953448L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((558140072882767585L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4790933420235738378L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((825070459594532123L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4220672880129868526L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3716263430087632916L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2818603773782987600L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5465425656567620901L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4428981993766056387L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((731873220707233644L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7908963909977520610L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2660411488798364942L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5379895146087216739L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6298098561793821898L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2476730285186990795L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3026134525435997214L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((77669112291107883L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8384990712818997693L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3628077860828676653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5806499143310841463L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3694280363945838175L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7037595474061418532L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5104647645415963032L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5834453749914921511L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9021852997057578478L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5379991909170133845L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8882436093598369077L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7907085868194142644L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8147043930342797939L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((568793734075291268L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3081766617534296776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2128594188661117312L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6760017640122824803L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7289192064159120967L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2638249903379276302L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5228535026163225411L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((48803224257945924L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8765814060134030635L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((407239961434994885L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7332596847993943801L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6909298376878134226L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2453047558768856136L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6205965132389167866L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7075049246598976188L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5309747519125515418L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1834788669076945702L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7779226874761754045L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2034265582630054542L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2956623885848673678L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6110066126148439115L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4110620948480813251L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1923153959972981417L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1332681976860787514L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3813566356433486464L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8237288783946100024L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3299521009744444325L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7662539468974110657L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8879034841642360270L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3518145485861964812L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7946830766455268956L)));

            }
        }

#endregion

    }
}

